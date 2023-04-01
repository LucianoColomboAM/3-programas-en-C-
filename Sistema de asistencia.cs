 { class persona {
    public string nombre;
    public string apellido;
    public virtual void datos(){
        
        Console.WriteLine("El nombre es "+nombre +" el apellido es " +apellido);
        }
    }
    
    
   class alumno:persona{

    public override void datos()
    {
        base.datos();
        
    }
    public void faltas(){
         int auxfalt=0;
        Console.WriteLine("Ingrese el numero de faltas");
        int n=Convert.ToInt32(Console.ReadLine());
        if (n>20){
        Console.WriteLine("El alumno excedió el limite de faltas");
        }
        
 
        }
    }
    class preceptor:persona{
         public override void datos(){
            base.datos();
        }
        public void asistencias(){
             Console.WriteLine("Ingrese la cantidad de alumnos de este curso");
        int n=Convert.ToInt32(Console.ReadLine());
        int auxasist=0;
        int auxasist2=0;
        double auxinasist=0;
        double auxinasist2=0;        
        for (int i=1;i<=n;i++){
        Console.WriteLine("El alumno "+i+" en la lista faltó?(1 para si, 2 para no)");
        int n2=Convert.ToInt32(Console.ReadLine());
        if (n2==2){
        auxinasist=auxinasist+1;    
        }
        if(n2==1){
        auxasist=auxasist+1;        
        }
            }
        
        auxinasist2=((auxinasist/n)*100);
        Console.WriteLine("El porcentaje de alumnos que faltaron fue "+auxinasist2);
        auxasist2=((auxasist/n)*100);
        Console.WriteLine("El porcentaje de alumnos que asistieron fue "+auxasist2);
         }
        
    }
      class profesor:persona{
        public override void datos(){
             base.datos();}
        public void horas(){
            Console.WriteLine("Ingrese sueldo comun del profesor");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Horas trabajadas este mes");
            double n1 = Convert.ToDouble(Console.ReadLine());
            if(n1 > 30)
            {
                double sueldo=(n*0.15) +n;
            Console.WriteLine("Su sueldo trabajando mas de 30 horas sera " + sueldo);
            }    
            else
            {
                Console.WriteLine("Su sueldo es" + (n));
            }
    
                    
  
        }
    }
  
    
}
    class Program
    {
        public static void Main(string[] args)
        {    
           alumno objal;
            objal= new alumno();
            Console.WriteLine("Ingrese primero nombre, luego apellido del alumno");
            objal.nombre=Convert.ToString(Console.ReadLine());
            objal.apellido=Convert.ToString(Console.ReadLine());
            objal.datos();
            objal.faltas();
            
            profesor objpr;
            objpr= new profesor();
            Console.WriteLine("Ingrese primero nombre, luego apellido del profesor");
            objpr.nombre=Convert.ToString(Console.ReadLine());
            objpr.apellido=Convert.ToString(Console.ReadLine());
            objpr.datos();
            objpr.horas();
            
            preceptor objpre;
            objpre=new preceptor();
             Console.WriteLine("Ingrese primero nombre, luego apellido del preceptor");
            objpre.nombre=Convert.ToString(Console.ReadLine());
            objpre.apellido=Convert.ToString(Console.ReadLine());
            objpre.datos();
            objpre.asistencias();
            
                
            
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }