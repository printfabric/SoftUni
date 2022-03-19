# from operator import div
from unittest import TestCase, main
from project.vehicle import Vehicle


class VehicleTest(TestCase):
    def setUp(self):
        self.vehicle = Vehicle(1.25, 130.3)

    def test_default_class_attributes(self):
        vehicle = self.vehicle
        self.assertEqual(type(vehicle.DEFAULT_FUEL_CONSUMPTION), float)
        self.assertEqual(type(vehicle.fuel_consumption), float)
        self.assertEqual(type(vehicle.fuel), float)
        self.assertEqual(type(vehicle.capacity), float)
        self.assertEqual(type(vehicle.horse_power), float)

    def test_vehicle_is_initialised_correctly(self):
        vehicle = self.vehicle
        fuel = 1.25
        hp = 130.3
        default_fc = 1.25
        vehicle = Vehicle(fuel, hp)

        self.assertEqual(1.25, vehicle.fuel)
        self.assertEqual(130.3, vehicle.horse_power)
        self.assertEqual(vehicle.capacity, fuel)
        self.assertEqual(vehicle.horse_power, hp)
        self.assertEqual(vehicle.fuel, default_fc)

    def test_drive(self):
        vehicle = self.vehicle
        kilometers = 1

        self.vehicle.drive(kilometers)
        self.assertEqual(vehicle.fuel, 0)

    def test_drive_exception_raise(self):
        vehicle = self.vehicle
        kilometers = 100

        with self.assertRaises(Exception) as ex:
            vehicle.drive(kilometers)
        self.assertEqual("Not enough fuel", str(ex.exception))

    def test_refuel(self):
        vehicle = Vehicle(10.0, 130.3)
        vehicle.drive(8)
        vehicle.refuel(10.0)
        self.assertEqual(vehicle.fuel, 10)

    def test_refuel_exception_raise(self):
        vehicle = self.vehicle
        fuel = 100

        with self.assertRaises(Exception) as ex:
            vehicle.refuel(fuel)
        self.assertEqual("Too much fuel", str(ex.exception))

    def test_str(self):
        vehicle = self.vehicle
        res = f"The vehicle has 130.3 horse power with 1.25 fuel left and 1.25 fuel consumption"
        self.assertEqual(res, str(vehicle))


if __name__ == "__main__":
    main()



