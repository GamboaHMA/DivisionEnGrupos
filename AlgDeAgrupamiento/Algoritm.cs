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


        public void ClustersR(List<Distance> HeapMax, List<Entity> entities)
        {
            int count = 1;

            List<List<Entity>> clusters = new List<List<Entity>>();
            List<List<Entity>> clusters_c = new List<List<Entity>>();

            Entity e1 = HeapMax[0].Element1;                                          // caso inicial
            Entity e2 = HeapMax[0].Element2;

            clusters.Add(new List<Entity>() { e1 }); e1.group = count;                // asigno un elemento al grupo A y otro al grupo B
            clusters_c.Add(new List<Entity>() { e2 }); e2.group = -1 * count;         // y luego le añado a la propiedad del elemento su grupo

                                                                                      // asumimos que el grupo 1 es el A, y el grupo -1 es el B

            ClustersR(HeapMax, entities, clusters, clusters_c, e1, e2, count, 3);     
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
                    if  ((Math.Abs(e1.group) == 1 && Math.Abs(e2.group) != 1) ||
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
                if(e2.group == 0)
                {
                    c1[-1 * e1.group].Add(e2); e2.group = -1 * e1.group;
                }

                else
                {
                    int group = e2.group;
                    if (group < 0)
                    {
                        foreach (var item in c2[-1 * group])
                        {
                            c1[-1 * e1.group].Add(item); item.group = -1 * e1.group; 
                        }
                        c2[-1 * group].Clear();

                        foreach (var item in c1[-1 * group])
                        {
                            c2[-1 * e2.group].Add(item); item.group = e1.group;
                        }
                        c1[-1 * group].Clear();
                    }

                    else
                    {
                        foreach (var item in c1[group])
                        {
                            c1[-1 * e1.group].Add(item); item.group = -1 * e1.group;
                        }
                        c1[group].Clear();

                        foreach (var item in c2[group])
                        {
                            c2[-1 * e1.group].Add(item); item.group = e1.group;
                        }
                        c2[group].Clear();
                    }
                }
            }

            else
            {
                if (e2.group == 0)
                {
                    c2[e1.group].Add(e2); e2.group = -1 * e1.group;
                }

                else
                {
                    int group = e2.group;
                    if (group < 0)
                    {
                        foreach (var item in c2[-1 * group])
                        {
                            c2[e1.group].Add(item); item.group = -1 * e1.group;
                        }
                        c2[-1 * group].Clear();

                        foreach (var item in c1[-1 * group])
                        {
                            c1[e1.group].Add(item); item.group = e1.group;
                        }
                        c1[-1 * group].Clear();
                    }

                    else
                    {
                        foreach (var item in c1[group])
                        {
                            c2[e1.group].Add(item); item.group = -1 * e1.group;
                        }
                        c1[group].Clear();

                        foreach (var item in c2[group])
                        {
                            c1[e1.group].Add(item); item.group = e1.group;
                        }
                        c2[group].Clear();
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
    }
}
