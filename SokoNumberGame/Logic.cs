using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading; 
using Priority_Queue;

namespace SokoNumberGame
{
    class Logic
    {
        private Stack<Structure> solution;
        private Queue<Structure> q;
        private Stack<Structure> s;
        private Dictionary<String, bool> HashVisited;
        private SimplePriorityQueue<Structure,int> pq;
        private bool finish;
        private DateTime start;
        private TimeSpan time;
        private int visitedCount;

        //Constroctor
        public Logic()
        {
            visitedCount = 0;
            HashVisited = new Dictionary<string, bool>();
            start = DateTime.Now;
            solution = new Stack<Structure>();
            finish = false;
        }

        //Get Solution Methods
        public void printSolution(Form1 form,decimal speed)
        {
            if (this.solution.Count == 0)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Thread.Sleep((int)speed);
            this.solution.First().print(form);
            this.solution.Pop();
            if (this.solution.Count != 0)
                printSolution(form,speed);
        }
        public void GetSolution(Structure state,Form1 form)
        {
            form.time = this.time;
            form.visitedCount = this.visitedCount;
            if (state.father != null)
            {
                this.solution.Push(state);
                form.movesCount++;
                GetSolution(state.father,form);
            }
        }

        //Search Algorithms
        public void DFS(Structure state, Form1 form)
        {
            //check if state is visited
            bool is_visited;
            this.HashVisited.TryGetValue(state.getHashString(), out is_visited);
            if (!is_visited)
            {
                //Add to visited
                HashVisited.Add(state.getHashString(), true);

                //end condition
                if (state.isFinal())
                {
                    //Boolean value for stop recursion
                    this.finish = true;

                    //calculating time
                    this.time = DateTime.Now.TimeOfDay - start.TimeOfDay;

                    //calculating visited states count
                    this.visitedCount = this.HashVisited.Count;

                    //Get Sloution Path
                    this.GetSolution(state, form);

                    return;
                }

                //Get Next States
                foreach (Structure next in state.getNextStates())
                {
                    //Recursion
                    DFS(next, form);

                    //Stop Recursion
                    if (this.finish) return;
                }
            }
        }
        public void BFS(Structure state,Form1 form)
        {
            //create queue and initialization
            q = new Queue<Structure>();
            q.Enqueue(state);

            while (q.Count != 0)
            {
                Structure v = new Structure();
                v = q.Dequeue();

                //check if state is visited
                bool is_visited;
                this.HashVisited.TryGetValue(v.getHashString(), out is_visited);
                if (!is_visited)
                {
                    //Add to visited
                    HashVisited.Add(v.getHashString(),true);

                    //End condition
                    if (v.isFinal())
                    {
                        //calculating time
                        this.time = DateTime.Now.TimeOfDay - start.TimeOfDay;

                        //calculating visited states count
                        this.visitedCount = this.HashVisited.Count;

                        //get solution path
                        this.GetSolution(v,form);

                        return;
                    }

                    //Get next states
                    foreach (Structure next in v.getNextStates())
                    {
                        //Add to queue
                        q.Enqueue(next);
                    }
                }
            }
        }
        public void UCS(Structure state,Form1 form)
        {
            //create priority queue and initialzation
            pq = new SimplePriorityQueue<Structure, int>();
            pq.Enqueue(state, state.Cost);

            while (pq.Count != 0)
            {
                Structure v = new Structure();
                v = pq.Dequeue();

                //check if state is visited
                bool is_visited;
                this.HashVisited.TryGetValue(v.getHashString(), out is_visited);
                if (!is_visited)
                {
                    //Add to visited
                    this.HashVisited.Add(v.getHashString(), true);
                    
                    //End condition
                    if (v.isFinal())
                    {
                        //calculating time
                        this.time = DateTime.Now.TimeOfDay - start.TimeOfDay;

                        //calculating visited states count
                        this.visitedCount = this.HashVisited.Count;

                        //get solution path
                        this.GetSolution(v,form);

                        return;
                    }

                    foreach (Structure next in v.getNextStates())
                    {
                        //Add to priority queue
                        pq.Enqueue(next,next.Cost);
                    }
                }
            }
        }
        public void A_Star(Structure state, Form1 form)
        {
            //create priority queue and initialzation
            pq = new SimplePriorityQueue<Structure, int>();
            pq.Enqueue(state, state.Cost+state.getHeuristic());
                
            while (pq.Count != 0)
            {
                Structure v = new Structure();
                v = pq.Dequeue();

                //check if state is visited
                bool is_visited;
                this.HashVisited.TryGetValue(v.getHashString(), out is_visited);
                if (!is_visited)
                {
                    //Add to visited
                    this.HashVisited.Add(v.getHashString(), true);

                    //End condition
                    if (v.isFinal())
                    {
                        //calculating time
                        this.time = DateTime.Now.TimeOfDay - start.TimeOfDay;

                        //calculating visited states count
                        this.visitedCount = this.HashVisited.Count;

                        //get solution path
                        this.GetSolution(v, form);

                        return;
                    }

                    foreach (Structure next in v.getNextStates())
                    {
                        //Add to priority queue
                        pq.Enqueue(next, next.Cost+next.getHeuristic());
                    }
                }
            }
        }


        //old functions
        //public void StackDFS(Structure state,Form1 form)
        //{
        //    s = new Stack<Structure>();
        //    Structure v = new Structure();
        //    s.Push(state);

        //    while (s.Count != 0)
        //    {
        //        v = s.Pop();
        //            visited.Add(v);

        //        if (v.isFinal())
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("Stack DFS Algorithm:");
        //            Console.WriteLine("time: " + (DateTime.Now.TimeOfDay - start.TimeOfDay));
        //            Console.WriteLine("visitedd count: " + this.visited.Count);

        //            this.GetSolution(v,form);

        //            Console.WriteLine("Cost: " + v.Cost);

        //            return;
        //        }
        //        foreach (Structure next in v.getNextStates())
        //        {
        //            if (this.isVisited(next) == false)
        //            {
        //                s.Push(next);
        //            }
        //        }
        //    }
        //}
        //public bool isVisited(Structure state)
        //{

        //    foreach (Structure s in this.visited)
        //    {
        //        if (s.equals(s, state)) return true;
        //    }

        //    return false;
        //}
    }
}
