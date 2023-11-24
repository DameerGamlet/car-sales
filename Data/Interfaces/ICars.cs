public interface ICars
{
    IEnumerable<Car> GetAllCars();
    Car GetCarById(int id);
    void AddCar(Car car);
    void UpdateCar(Car car);
    void DeleteCar(int id);
}
