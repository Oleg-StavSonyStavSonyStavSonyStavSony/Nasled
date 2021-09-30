sing System;
namespace Nasled
{
     public sealed class SuperCube : Cube{
        public int?  edge7 { get; set; } = 7;
        public int?  edge8 { get; set; } = 8;
        public int?  edge9 { get; set; } = 9;

            
            //base()            -       конструктор родителя
            public Point3D(int? x1, int? x2, int? x3, int? x4, int? x5, int x6, int? x7, int? x8, int? x9) : base(x1,x2,x3,x4,x5,x6,7,8,9){
                this.edge7 = x7;
                this.edge7 = x8;
                this.edge7 = x9;
            }
            public SuperCube(Cube other) : this (other.x1, other.x2, other.x3,  other.x4,  other.x5, other.x6, 0, 0,0){

        }

        public override  int Play (){
             Console.WriteLine(random.Next(edge1, edge9));
        }

     }
}