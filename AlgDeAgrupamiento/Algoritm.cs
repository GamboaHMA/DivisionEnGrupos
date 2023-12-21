using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDeAgrupamiento
{
    public class Algoritm
    {
        public Algoritm()
        {

        }



        public List<List<Entity>> Clusters(List<List<Entity>> list, int nivel)
        {

            while (nivel != 0)
            {
                List<List<Entity>> result = new List<List<Entity>>();

                foreach (var item in list)
                {
                    if (item.Count > 2)
                    {
                        ClustersR(item);                                                     //Aplicamos algoritmo para asignar etiquetas
                        (List<Entity>, List<Entity>) clustersResult = ReturnGroups(item);    //Obtenemos los dos grupos en los que se dividio

                        List<Entity> less = clustersResult.Item1;
                        List<Entity> further = clustersResult.Item2;

                        result.Add(less); result.Add(further);
                    }

                    else result.Add(item);
                }

                list.Clear();

                foreach (var item in result)
                {
                    list.Add(item);         //Reasignamos a result los grupos obtenidos
                }

                nivel--;
            }

            return list;
        }

        public void ClustersR(List<Entity> entities)
        {
            List<Distance> distances = new List<Distance>();

            for (int i = 0; i < entities.Count; i++)
            {
                for (int j = i + 1; j < entities.Count; j++)
                {
                    Distance distance = new Distance(entities[i], entities[j], EuclidianDistance(entities[i].coordinates, entities[j].coordinates));
                    distances.Add(distance);
                }
            }


            int count = 1;

            Distance HeapMax = new Distance(distances);
            List<Entity> Entities = new List<Entity>();

            if (HeapMax.Arr != null)
            {
                foreach (var item in HeapMax.Arr)
                {
                    if (!Entities.Contains(item.Element1)) Entities.Add(item.Element1);
                    if (!Entities.Contains(item.Element2)) Entities.Add(item.Element2);
                }

                List<List<Entity>> clusters = new List<List<Entity>>();
                List<List<Entity>> clusters_c = new List<List<Entity>>();

                Entity e1 = HeapMax.Arr[0].Element1;                                          // caso inicial
                Entity e2 = HeapMax.Arr[0].Element2;

                clusters.Add(new List<Entity>() { e1 }); e1.group = count;                // asigno un elemento al grupo A y otro al grupo B
                clusters_c.Add(new List<Entity>() { e2 }); e2.group = -1 * count;         // y luego le añado a la propiedad del elemento su grupo                                                                                      // asumimos que el grupo 1 es el A, y el grupo -1 es el B

                ClustersR(HeapMax.Arr, Entities, clusters, clusters_c, e1, e2, count, 3);
            }
        }

        private void ClustersR(List<Distance> HeapMax, List<Entity> entities, List<List<Entity>> c1,
                                   List<List<Entity>> c2, Entity e1, Entity e2, int count, int step)
        {

            switch (step)
            {
                case 3:
                    HeapMax[0].Elimina();                                                     // eliminamos la distancia máxima del heap, asegurándonos de
                                                                                              // que en la raíz hay una nueva distancia máxima
                    e1 = HeapMax[0].Element1; e2 = HeapMax[0].Element2;                       // reasignamos los nuevos elementos que están a una dist máxima
                    count++;

                    if (e1.group == 0 && e2.group == 0) ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 4);
                    else ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 5);
                    break;

                case 4:
                    c1.Add(new List<Entity>() { e1 }); e1.group = count;
                    c2.Add(new List<Entity>() { e2 }); e2.group = -1 * count;

                    ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 3);
                    break;

                case 5:
                    if ((Math.Abs(e1.group) == 1 && Math.Abs(e2.group) != 1) ||
                         (Math.Abs(e1.group) != 1 && Math.Abs(e2.group) == 1))
                        ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 6);

                    else ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 8);
                    break;

                case 6:
                    if ((Math.Abs(e2.group) == 1)) ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 7);
                    else ChangeLabels(e1, e2, c1, c2);
                    break;

                case 7:
                    ChangeLabels(e2, e1, c1, c2);
                    ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 3);
                    break;

                case 8:
                    if (e1.group == 1 && e2.group == 1 || e1.group == -1 && e2.group == -1)
                        ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 16);
                    else if (e1.group == 1 && e2.group == -1 || e1.group == -1 && e2.group == 1)
                        ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 3);
                    else ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 9);
                    break;

                case 9:
                    if (e1.group != 0 && e2.group == 0 || e1.group == 0 && e2.group != 0)
                        ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 10);
                    else ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 12);
                    break;

                case 10:
                    if (e1.group != 0) ChangeLabels(e1, e2, c1, c2);
                    else ChangeLabels(e2, e1, c1, c2);    //--------------------------------------------- step 11
                    ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 3);
                    break;

                case 12:
                    if (e1.group == e2.group) ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 16);
                    else ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 13);
                    break;

                case 13:
                    if (e1.group == -1 * e2.group) ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 13);
                    else ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 14);
                    break;

                case 14:
                    if (e2.group < 0) ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 15);
                    ChangeLabels(e1, e2, c1, c2);
                    ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 3);
                    break;

                case 15:
                    ChangeLabels(e1, e2, c1, c2);
                    ClustersR(HeapMax, entities, c1, c2, e1, e2, count, 3);
                    break;

                case 16:
                    Finalizar(entities);
                    break;

                default:
                    break;
            }
        }

        private void ChangeLabels(Entity e1, Entity e2, List<List<Entity>> c1, List<List<Entity>> c2)
        {
            if (e1.group < 0)
            {
                if (e2.group == 0)
                {
                    c1[-1 * e1.group - 1].Add(e2); e2.group = -1 * e1.group;
                }

                else
                {
                    int group = e2.group;
                    if (group < 0)
                    {
                        foreach (var item in c2[-1 * group - 1])
                        {
                            c1[-1 * e1.group - 1].Add(item); item.group = -1 * e1.group;
                        }
                        c2[-1 * group - 1].Clear();

                        foreach (var item in c1[-1 * group - 1])
                        {
                            c2[-1 * e2.group - 1].Add(item); item.group = e1.group;
                        }
                        c1[-1 * group - 1].Clear();
                    }

                    else
                    {
                        foreach (var item in c1[group - 1])
                        {
                            c1[-1 * e1.group - 1].Add(item); item.group = -1 * e1.group;
                        }
                        c1[group - 1].Clear();

                        foreach (var item in c2[group - 1])
                        {
                            c2[-1 * e1.group - 1].Add(item); item.group = e1.group;
                        }
                        c2[group - 1].Clear();
                    }
                }
            }

            else
            {
                if (e2.group == 0)
                {
                    c2[e1.group - 1].Add(e2); e2.group = -1 * e1.group;
                }

                else
                {
                    int group = e2.group;
                    if (group < 0)
                    {
                        foreach (var item in c2[-1 * group])
                        {
                            c2[e1.group - 1].Add(item); item.group = -1 * e1.group;
                        }
                        c2[-1 * group - 1].Clear();

                        foreach (var item in c1[-1 * group - 1])
                        {
                            c1[e1.group - 1].Add(item); item.group = e1.group;
                        }
                        c1[-1 * group - 1].Clear();
                    }

                    else
                    {
                        foreach (var item in c1[group - 1])
                        {
                            c2[e1.group - 1].Add(item); item.group = -1 * e1.group;
                        }
                        c1[group - 1].Clear();

                        foreach (var item in c2[group - 1])
                        {
                            c1[e1.group - 1].Add(item); item.group = e1.group;
                        }
                        c2[group - 1].Clear();
                    }
                }
            }
        }

        private void Finalizar(List<Entity> entities)
        {
            Random random = new Random();
            foreach (var entity in entities)
            {
                if (entity.group < 0) entity.group = -1;
                else if (entity.group > 0) entity.group = 1;
                else
                {
                    if (random.Next(0, 1) == 0) entity.group = 1;
                    else entity.group = 0;
                }
            }
        }

        public (List<Entity>, List<Entity>) ReturnGroups(List<Entity> entities)
        {
            List<Entity> furhter = new List<Entity>();
            List<Entity> less = new List<Entity>();

            foreach (var item in entities)
            {
                if (item.group == 1)
                {
                    furhter.Add(item);
                    item.group = 0;                      // reasignamos el valor de la etiqueta de la entidad para en un futuro seguir
                }                                        // aplicándole el algoritmo y seguir agrupándola
                else
                {
                    less.Add(item);
                    item.group = 0;
                }
            }

            return (less, furhter);
        }

        public static List<List<Entity>> UpdateGroups(List<List<Entity>> list, int level)
        {
            List<List<Entity>> result = new List<List<Entity>>() { };    //inicializamos lista de listas

            for (int i = 0; i < level; i++)
            {
                result.Add(new List<Entity>());            //inicializamos listas de entidades
            }

            foreach (var item in list)
            {
                foreach (var entity in item)
                {
                    result[entity.group].Add(entity);
                }
            }

            return result;
        }

        public static double EuclidianDistance(List<double> ent1, List<double> ent2)
        {
            double tot = 0;
            for (int i = 0; i < ent1.Count; i++)
            {
                tot += Math.Pow(ent1[i] - ent2[i], 2);
            }

            double result = Math.Sqrt(tot);

            return result;
        }

        public static List<double> GetVariance(List<double> media, List<Entity> group)
        {
            List<double> result = new List<double>();//inicializamos la lista de varianzas a devolver

            if (group.Count != 0)//verificamos que el grupo contenga entidades
            {
                foreach (var entity in group[0].coordinates) { result.Add(0); }//inicializamos valores del resultado

                foreach (var item in group)//iteramos por cada entidad
                {
                    for (int i = 0; i < item.coordinates.Count; i++)//iteramos por cada parámetro
                    {
                        double coordinate = Math.Pow(item.coordinates[i] - media[i], 2);//restamos promedio al valor del parámetro
                        result[i] += coordinate;//acumulamos
                    }
                }

                VectorialDiv(result, group.Count);//dividimos entre el total de entidades para hallar el valor promedio de dispersión o sea la varianza

                return result;
            }

            return result;
        }
        public static void VectorialDiv(List<double> centroids, int count)     //divide cada coordenada del vector entre el entero count
        {
            for (int i = 0; i < centroids.Count; i++)
            {
                centroids[i] = centroids[i] / count;
            }
        }
        public static void VectorialSum(List<double> list, List<double> coordinates)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += coordinates[i];
            }
        }


    }
}