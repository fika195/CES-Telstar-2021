using static RouteCalculatorVehicles.car;

[TestMethod]
public void createCar()
{

    RouteCalculatorVehicles.car testCar = Car();


    Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");

    Assert.AreEqual(testCar.getVehicleType, "car", 0.001, "Account not debited correctly");
}