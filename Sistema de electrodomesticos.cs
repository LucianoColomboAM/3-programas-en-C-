using System;
using punto2;

namespace punto2
{    class electrodomesticos{
        public int largo,alto,marca,modelo,adg,año;
        public virtual void datos(){

    Console.WriteLine("Ingrese el largo del producto");
      largo=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine( "Ingrese el alto del producto");
      alto=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine( "Ingrese la marca del producto");
      marca=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine( "Ingrese el modelo del producto");
      modelo=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine( "Ingrese los años de garantia del producto");
      adg=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine( "Ingrese año en el que fue comprado el producto");
      año=Convert.ToInt32(Console.ReadLine());
    
        }
    public virtual void garantia(){
            int auxg = (año + adg);
            Console.WriteLine("La garantia se terminara en" + auxg);
        }

    }
    class heladera:electrodomesticos{
            public override void datos(){
            Console.WriteLine("Ingrese los siguientes datos de la heladera");
                base.datos();
            }
            public override void garantia(){
                base.garantia();
            }
            public void canthielo(){
                Console.WriteLine("Ingrese cantidad de minutos");
                int minutos=Convert.ToInt32(Console.ReadLine());
                if (minutos%25==0){
                    Console.WriteLine("La cantidad de cubos de hielo que producira en esa cantiad de minutos");
                    Console.WriteLine((minutos/25) * 8);     
                }
                else{
                    Console.WriteLine("La cantidad de cubos de hielo que producira en esa cantidad de minutos sera");
                    int aux = (minutos/25);
                    Console.WriteLine(aux * 8);
                }
            }
        }
    class cocina:electrodomesticos{
            public override void datos(){
            Console.WriteLine("Ingrese los siguientes datos de la cocina");
                base.datos();
            }
            public override void garantia(){
                base.garantia();
            }
        public void coccion(){
            Console.WriteLine("Ingrese que va a cocinar(1 para verduras, 2 para pollo, 3 para carne");
        int n=Convert.ToInt32(Console.ReadLine());
        if (n==1){
            Console.WriteLine("Cocinará a fuego minimo o maximo(1 para si, 2 para no)");
            int n1=Convert.ToInt32(Console.ReadLine());
            if(n1==1){
            Console.WriteLine("Esto tardara 10 minutos");
                }
            else{
            Console.WriteLine("Esto tardara 5 minutos");    
                }
            }
        if(n==2){
        int n2=Convert.ToInt32(Console.ReadLine());
            if(n2==1){
            Console.WriteLine("Esto tardara 35 minutos");
                }
            else{
            Console.WriteLine("Esto tardara 25 minutos");    
                }    
        }
        if(n==3){
        int n3=Convert.ToInt32(Console.ReadLine());
            if(n3==1){
            Console.WriteLine("Esto tardara 50 minutos");
                }
            else{
            Console.WriteLine("Esto tardara 40 minutos");    
                }    
            }
        }
    }
    class lavarropas:electrodomesticos{
        public override void datos(){
            Console.WriteLine("Ingrese los siguientes datos del lavarropas");
                base.datos();
            }
            public override void garantia(){
                base.garantia();
            }
              public void lavar(){
               Console.WriteLine("Ingrese los kilogramos de ropa a lavar (6,7 o 9)");
               int n=Convert.ToInt32(Console.ReadLine());
               if (n==6) {
                   Console.WriteLine("Se consumiran 9 litros con un lavado Economico");
               }
                   if (n==7){
                    Console.WriteLine("Se consumiran 12 litros con un lavado Normal");
                   }
                   if (n==9){
                    Console.WriteLine("Se consumiran 15 litros con un lavado Full");
                   }
               
        }
    }
    
}

    class Program
    {
        public static void Main(string[] args)
        {
            heladera objhe;
            objhe = new heladera();
            objhe.datos();
            objhe.garantia();
            objhe.canthielo();
            
            cocina objco;
            objco = new cocina();
            objco.datos();
            objco.garantia();
            objco.coccion();
            
               lavarropas objla;
            objla = new lavarropas();
            objla.datos();
            objla.garantia();
            objla.lavar();
            
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }