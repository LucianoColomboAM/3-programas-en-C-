{    class atributos{
        public string nombre, apellido;
        public virtual void datos(){
         Console.WriteLine("Ingrese nombre");
           nombre=(Console.ReadLine());
         Console.WriteLine( "Ingrese apellido");
           apellido=(Console.ReadLine());
        }

    }
    class empleado:atributos{
          public override void datos(){
            Console.WriteLine("Ingrese los siguientes datos del empleado");
                base.datos();
            }
        public void sueldo(){
            Console.WriteLine("Ingrese sueldo base");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese antiguedad");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese mes");
            int n2=Convert.ToInt32(Console.ReadLine());
            int aux=5;
             int aux2=0;
            double sueldototal=0;
            
            while(n1>=aux){
              aux2=aux2+7;
              n1=(n1-aux);    
            }
            sueldototal=n+((n*aux2)/100);
            Console.WriteLine("Su sueldo con la bonificacion de antiguedad es "+sueldototal);
            if(n2==6||n2==12){
                sueldototal=sueldototal+(n*0.5);
                Console.WriteLine("Su sueldo con aguinaldo será "+sueldototal);
            }
        }
    }
    class cliente:atributos{
         public override void datos(){
            Console.WriteLine("Ingrese los siguientes datos del cliente");
                base.datos();
            }
        public void pagar(){
            Console.WriteLine("Ingrese la cantidad de articulos comprados");
            int n=Convert.ToInt32(Console.ReadLine());
            double aux=0;
            for(int i=1;i<=n;i++){
            Console.WriteLine("Ingrese el precio del producto "+i);
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de este producto "+i);
            int n2=Convert.ToInt32(Console.ReadLine());
            aux=aux+(n1*n2);
            }
            if (aux>500){
            aux=aux-50;    
            }
            Console.WriteLine("La compra será a efectivo?(1 para si, 2 para no)");
            int n3=Convert.ToInt32(Console.ReadLine());
            if(n3==1){
                aux=aux-(aux*0.15);
                Console.WriteLine("El precio a pagar por esta compra será de "+aux);
            }
            else{
            Console.WriteLine("El precio a pagar por esta compra será de "+aux);    
            }
            
        }
        
    }
        class articulo{
  
        public void precio(){
            Console.WriteLine("Ingrese precio de costo");
            double n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese margen de ganancia que quiera sacar en %");
            double n2=Convert.ToDouble(Console.ReadLine());
            
            double aux=n+((n*n2)/100);
            Console.WriteLine("El precio total del producto sera " + aux);
            double aux2=aux-n;
            Console.WriteLine("La ganancia que se le ha sacado a este producto es de "+aux2);
        }
     

        
        
    }

}

    class Program
    {
        public static void Main(string[] args)
        {
        
            empleado objem;
            objem= new empleado();
            objem.datos();
            objem.sueldo();
            
            cliente objcl;
            objcl=new cliente();
            objcl.datos();
            objcl.pagar();
            
            articulo objar;
            objar=new articulo();
            objar.precio();
         
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
