public class Car
{
    int power;
    int price;
    int brand; 

    public Car(int power, int price, int brand){
        this.power = power;
        this.price = price;
        this.brand = brand;
    }

    public int getPrice(){
        return power * brand;
    } 

}
    public class Simple{
        public static void Main(){
            Car firstCar = new Car(10, 2, 5);
            Console.WriteLine(firstCar.getPrice());
        }
}

        










