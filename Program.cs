/*
Objectives 

To demonstrates the use of a STATIC variable AND a STATIC getter method for it
To demonstrate PRIVATE service methods called only by public methods
To demonstrate the use of this to reference instance variables
Activities: Box Class

_______________________________________________________________________________________________

In this exercise, you will write a class that models a Box  based on the following UML description.

Box CLASS   (UML description)

-  count     : int   STATIC
--------------------------------------------------- OBJECT ATTRIBUTES
-  length    :  int
-  width     :  int
-  height    :  int
-  weight    :  int
-  boxNumber :  int
---------------------------------------------------- OBJECT BEHAVIORS
+  getCount ()      :  int   STATIC
+  getBoxNumber ()  :  int

(setters not needed)

+  Box (length    :  int ,  width     :  int ,  height    :  int ,  weight    :  int ,  boxNumber :  int )      


+  findVolume ()              :  int
+  findSurfaceArea ()         :  int
+  findFootprint ()           :  int

+  isOverWeight (limit : int ) :  boolean

 
+  BoxInfo()                :  String


-  surfaceArea (dimen1 : int,  dimen2 : int) :  int

Write the  class assuming a box object is described by five pieces of instance data ( length, width, height, weight, and boxNumber as integer) and one piece of static variable count to hold the number of available  box objects

The class should have the following methods:

a.       A constructor that has five parameter that have the same name as instance variables..

b.      Two getters  a static method getCount(  ) that returns count and a method getBoxNumber(  ) to return boxNumber

c.       findVolume(  )  to return the volume of the box as integer, findSurfaceArea(  )  to return the surface area of the box as integer,    findFootprint(  )  to return the foot print of the box as an integer(the area of the bottom of the box) and  isOverWeight (limit : int ) to return true if weight is greater than limit and false otherwise. 

d.       A private method surfaceArea(dimen1 : int,  dimen2 : int) which will be used by the findSurfaceArea(  ) to support in calculating  the total surface area.

e.       A BoxInfo method that returns a string containing complete information of the box.

 

2.     Write a program that uses 3 box objects . Your program should do the following:

Read in the information of the three boxs and construct an object for each.
Print the info of each box (you will use the BoxInfo method here).
Print the number of Box objects created 
print if a box object is over the limit of 3kg or not
*/
using System;
namespace BOX
{
    internal class Program
    {
        static void Main(string[] args)
        {               //السلام عليكم ورحمه الله تعالى وبركاته 
            Box[] boxes = new Box[3]; //0000000008977
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter length,width,heiht,weight,boxNumber for Box{i+1}:");
                Console.WriteLine("Enter length:");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter width:");
                int width = int.Parse(Console.ReadLine());ss
                Console.WriteLine("Enter height:");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter weight:");
                int weight = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter boxNumber:");gi
                int boxNumber = int.Parse(Console.ReadLine());
                boxes[i] = new Box(length, width, height, weight, boxNumber);
                Console.Clear();  //وظيفتها تفضي الكونسول يعني تشطب اللي في واذا ما حطيتها بطلعو كلهم فوق بعض
            }   
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(boxes[i].BoxInfo());
                }
            Console.WriteLine("Total numberof Box objects:"+Box.getCount());
            //التشيك
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine( /*$لتفعيل النص*/$"Box {boxes[i].getBoxNumber()}" + boxes[i].isOverWeight(3) +"?"+"isoverweight"+"is not overweight");
            }
        }
    }
    class Box
    {
        private static int Count=0;
        private int length, width, height, weight, boxNumber;
        public Box(int length , int width , int height , int weight , int boxNumber)
        {// Can be used (this) for (excellence=للتميز)
            this.length = length;
            this.width = width;
            this.height = height;
            this.weight = weight;
            this.boxNumber = boxNumber;
            Count++;// because the Count is equal 3
        }
        //الان نحتاج داله للحصول على عدد الصناديق
        public static int getCount()
        {
            return Count;
        }
        // داله للحصول على رقم الصندوق 
        public int getBoxNumber()
        {
            return this.boxNumber;
        }
        // داله لحساب حجم الصندوق 
        public int findVolume()
        {
            return length * width * height;
        }
        // private helper methomd
        private int surfaceArea(int dimen1, int dimen2)
        {
            return  2*dimen1*dimen2;
        }
        public int findSurfaceArea()
        {
            int side1 = surfaceArea(length,width);
            int side2 = surfaceArea(length,height);
            int side3 = surfaceArea(width,height);
            return side1 + side2 + side3;
        }
        //  داله لحساب مساحه القاعة
        public int findFootprint()
        {
            return length * width;
        }
        // داله للتحقق اذا كان الوزن يتجاوز الحد المطلوب 
        public Boolean isOverWeight(int limit)   //عشان اكبر او اصغر نستخدم (Boolean)
        {
            return weight > limit;
        }
        public string BoxInfo()  // فكرة جديدة للطباعه 
        {       /*$لتفعيل النص*/
            return $"Box Number:{boxNumber}\n" + $"Length:{length}\n" + $"Width:{width}\n" + $"Height:{height}\n" + $"Weight:{weight}\n"
                + $"Volume:{findVolume()}\n" + $"SurfaceArea:{findSurfaceArea()}\n" + $"Footprint:{findFootprint()}\n";
        }
    }
}