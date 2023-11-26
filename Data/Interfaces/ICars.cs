public interface ICars {
    IEnumerable<Car> GetAllCars();
    IEnumerable<Car> GetAllCarsByBrand(int brandId);
    IEnumerable<Car> GetAllCarsByType(int typeId);
    IEnumerable<Car> GetLastCars(int n);
    Car GetCarById(int id);
    void AddCar(Car car);
    void UpdateCar(Car car);
    void DeleteCar(int id);
}
