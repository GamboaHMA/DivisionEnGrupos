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

        public (List<Entity>, List<Entity>) Clusters(List<Distance> list)
        {
            Distance HeapMax = new Distance(list);
            List<Entity> Entities = new List<Entity>();

            foreach (var item in HeapMax.Arr)
            {
                if (!Entities.Contains(item.Element1)) Entities.Add(item.Element1);
                if (!Entities.Contains(item.Element2)) Entities.Add(item.Element2);
            }

            Clusters(HeapMax.Arr, Entities);

            List<Entity> GroupA = new List<Entity>();
            List<Entity> GroupB = new List<Entity>();

            foreach (var item in Entities)
            {
                if (item.group == 1) GroupA.Add(item);
                else GroupB.Add(item);
            }

            return (GroupA, GroupB);


        }

        public void Clusters(List<Distance> HeapMax, List<Entity> entities)

        {
            int count = 1;

            List<List<Entity>> clusters = new List<List<Entity>>();
            List<List<Entity>> clusters_c = new List<List<Entity>>();

            Entity e1 = HeapMax[0].Element1;
            Entity e2 = HeapMax[0].Element2;

            clusters.Add(new List<Entity>() { e1 }); e1.group = count;
            clusters_c.Add(new List<Entity>() { e2 }); e2.group = -1 * count;

            count++;


            while (true)
            {
                HeapMax[0].Elimina();

                e1 = HeapMax[0].Element1; e2 = HeapMax[0].Element2;                         // step 3

                if (e1.group == 0 && e2.group == 0)                                         // step 4
                {
                    clusters.Add(new List<Entity> { e1 }); e1.group = count;
                    clusters_c.Add(new List<Entity> { e2 }); e2.group = -1 * count;

                    count++;

                    continue;
                }
                // step 5

                if ((Math.Abs(e1.group) == 1 && Math.Abs(e2.group) != 1) || (Math.Abs(e1.group) != 1 && Math.Abs(e2.group) == 1))  // step 6
                {
                    if (Math.Abs(e1.group) == 1)
                    {
                        if (e2.group == 0)
                        {
                            if (e1.group == 1) { e2.group = -1; clusters_c[0].Add(e2); }
                            else { e2.group = 1; clusters[0].Add(e2); }
                            continue;
                        }

                        else
                        {
                            if (e1.group == 1)
                            {
                                int group = e2.group;
                                if (group < 0)
                                {
                                    foreach (var item in clusters_c[-1 * group - 1])
                                    {
                                        item.group = -1; clusters_c[0].Add(item);
                                    }
                                    clusters_c[-1 * group - 1].Clear();
                                    continue;
                                }

                                else
                                {
                                    foreach (var item in clusters[group - 1])
                                    {
                                        item.group = -1; clusters_c[0].Add(item);
                                    }
                                    clusters[group - 1].Clear();
                                    continue;
                                }
                            }

                            else
                            {
                                int group = e2.group;
                                if (group < 0)
                                {
                                    foreach (var item in clusters_c[-1 * group - 1])
                                    {
                                        item.group = 1; clusters[0].Add(item);
                                    }
                                    clusters_c[-1 * group - 1].Clear();
                                    continue;
                                }

                                else
                                {
                                    foreach (var item in clusters[group - 1])
                                    {
                                        item.group = 1; clusters[0].Add(item);
                                    }
                                    continue;
                                }
                            }
                        }
                    }
                    // step 7

                    else
                    {
                        if (e1.group == 0)
                        {
                            if (e2.group == 1) { e1.group = -1; clusters_c[0].Add(e1); }
                            else { e1.group = 1; clusters[0].Add(e1); }
                            continue;
                        }

                        else
                        {
                            if (e2.group == 1)
                            {
                                int group = e1.group;
                                if (group < 0)
                                {
                                    foreach (var item in clusters_c[-1 * group - 1])
                                    {
                                        item.group = -1; clusters_c[0].Add(item);
                                    }
                                    clusters_c[-1 * group - 1].Clear();
                                    continue;
                                }

                                else
                                {
                                    foreach (var item in clusters[group - 1])
                                    {
                                        item.group = -1; clusters_c[0].Add(item);
                                    }
                                    clusters[group - 1].Clear();
                                    continue;
                                }
                            }

                            else
                            {
                                int group = e1.group;
                                if (group < 0)
                                {
                                    foreach (var item in clusters_c[-1 * group - 1])
                                    {
                                        item.group = 1; clusters[0].Add(item);
                                    }
                                    clusters_c[-1 * group - 1].Clear();
                                    continue;
                                }

                                else
                                {
                                    foreach (var item in clusters[group - 1])
                                    {
                                        item.group = 1; clusters[0].Add(item);
                                    }
                                    clusters[group - 1].Clear();
                                    continue;
                                }
                            }
                        }


                    }

                }

                if ((e1.group == 1 && e2.group == -1) || (e1.group == -1 && e2.group == 1))    // step 8
                {
                    continue;
                }

                if ((e1.group == 1 && e2.group == 1) || (e1.group == -1 && e2.group == -1))    // step 16
                {
                    Finalizar(entities);
                    break;
                }

                if (Math.Abs(e1.group) != 1 && Math.Abs(e2.group) != 1)                        // step 9
                {
                    if (e1.group < 0 && e2.group == 0)
                    {
                        clusters[-1 * e1.group - 1].Add(e2); e2.group = -1 * e1.group;
                        continue;
                    }

                    else if (e1.group > 0 && e2.group == 0)
                    {
                        clusters_c[e1.group - 1].Add(e2); e2.group = -1 * e1.group;
                        continue;
                    }

                    else if (e1.group == 0 && e2.group < 0)
                    {
                        clusters[-1 * e2.group - 1].Add(e1); e1.group = -1 * e2.group;
                        continue;
                    }

                    else if (e1.group == 0 && e2.group > 0)
                    {
                        clusters_c[e2.group - 1].Add(e1); e1.group = -1 * e2.group;
                        continue;
                    }

                    else if (e1.group == e2.group)                                                  // step 16
                    {
                        Finalizar(entities);
                        break;
                    }

                    else if (e1.group == e2.group * -1) continue;

                    else if (e1.group > 0 && e2.group < 0)                                          // step 14
                    {
                        int group = e2.group * -1;
                        foreach (var item in clusters_c[group - 1])
                        {
                            item.group = e1.group * -1; clusters_c[e1.group - 1].Add(item);
                        }

                        foreach (var item in clusters[group - 1])
                        {
                            item.group = e1.group; clusters[e1.group - 1].Add(item);
                        }

                        clusters_c[group - 1].Clear();
                        clusters[group - 1].Clear();

                        continue;
                    }
                                                                                                    // step 15
                    else if(e1.group < 0 && e2.group < 0)
                    {
                        int group = e2.group * -1;
                        foreach (var item in clusters_c[group - 1])
                        {
                            item.group = e1.group * -1; clusters[e1.group * -1 - 1].Add(item); 
                        }

                        foreach (var item in clusters[group - 1])
                        {
                            item.group = e1.group; clusters_c[e1.group * -1 -1].Add(item);
                        }
                        clusters_c[group - 1].Clear();
                        clusters[group  - 1].Clear();

                        continue;
                    }

                    else if(e1.group > 0 && e2.group > 0)
                    {
                        int group = e2.group;
                        foreach (var item in clusters[group - 1])
                        {
                            item.group = e1.group * -1; clusters_c[e1.group - 1].Add(item);
                        }

                        foreach (var item in clusters_c[group - 1])
                        {
                            item.group = e1.group; clusters[e1.group - 1].Add(item);
                        }
                        clusters[group - 1].Clear();
                        clusters_c[group - 1].Clear();

                        continue;
                    }

                    else if (e1.group < 0 && e2.group > 0)
                    {
                        int group = e2.group;
                        foreach (var item in clusters[group - 1])
                        {
                            item.group = e1.group * -1; clusters[e1.group * -1 - 1].Add(item);
                        }

                        foreach (var item in clusters_c[group -1])
                        {
                            item.group = e1.group; clusters_c[e1.group * -1 - 1].Add(item);
                        }
                        clusters[group - 1].Clear();
                        clusters_c[group - 1].Clear();

                        continue;
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
