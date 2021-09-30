using System;
namespace Nasled
{
    public class Cube 
    {
        public int?  edge1 { get; set; } = 1;
        public int?  edge2 { get; set; } = 2;
        public int?  edge3 { get; set; } = 3;
        public int?  edge4 { get; set; } = 4;
        public int?  edge5 { get; set; } = 5;
        public int?  edge6 { get; set; } = 6;
         protected Cube(){
                this.edge1 = this.edge2 = this.edge3 = this.edge4 = this.edge5 = this.edge6 =0;  
        }
        public Random random{ get;}

        public virtual  int Play () {
            Console.WriteLine(random.Next(edge1, edge6));
        }

        
    } 


}