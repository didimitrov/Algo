namespace FactoryMethod
{
   abstract class Car
   {
       private CarType _type;

       protected Car(CarType type)
       {
           this.Type = type;
           ArrangeParts();
       }

       public CarType Type
       {
           get { return _type; }
           set { _type = value; }
       }

       private void ArrangeParts()
       {
       }

       // Do subclass level processing in this method
       public abstract void Construct();
   }
}
