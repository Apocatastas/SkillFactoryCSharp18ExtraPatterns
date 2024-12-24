
namespace BuilderTask
{
    class Program
    {
        /// <summary>
        ///  Клиентский код
        /// </summary>
        static void Main()
        {
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
        }
    } 
}