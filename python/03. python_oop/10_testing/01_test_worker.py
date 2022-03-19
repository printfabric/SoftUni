class Worker:

    def __init__(self, name, salary, energy):
        self.name = name
        self.salary = salary
        self.energy = energy
        self.money = 0

    def work(self):
        if self.energy <= 0:
            raise Exception('Not enough energy.')

        self.money += self.salary
        self.energy -= 1

    def rest(self):
        self.energy += 1

    def get_info(self):
        return f'{self.name} has saved {self.money} money.'


from unittest import TestCase, main


class WorkerTests(TestCase):
    def setUp(self):
        self.worker = Worker("Chep", 130, 20)

    def test_person_is_initialised_correctly(self):
        # Arrange and act
        worker = self.worker

        # Assert
        self.assertEqual("Chep", worker.name)
        self.assertEqual(130, worker.salary)
        self.assertEqual(20, worker.energy)
        self.assertEqual(0, worker.money)

    def test_worker_energy_increased_after_rest(self):
        # Arrange
        worker = self.worker
        self.assertEqual(20, worker.energy)

        # Act
        worker.rest()

        # Assert
        self.assertEqual(21, worker.energy)

    def test_person_works_with_negative_energy_raises_error(self):
        # Arrange
        worker = Worker("Chep", 130, 0)

        # Act
        with self.assertRaises(Exception) as ex:
            worker.work()

        # Assertion
        self.assertEqual("Not enough energy.", str(ex.exception))

    def test_worker_money_is_increased_after_work(self):
        # Arrange
        worker = self.worker
        self.assertEqual(0, worker.money)

        # Act
        worker.work()

        # Assert
        self.assertEqual(130, worker.money)

    def test_worker_energy_is_decreased_after_work(self):
        # Arrange
        worker = self.worker
        self.assertEqual(20, worker.energy)

        # Act
        worker.work()

        # Assert
        self.assertEqual(19, worker.energy)

    def test_get_info(self):
        # Arrange
        worker = self.worker

        # Act
        actual_result = worker.get_info()
        # expected_result = "Chep has saved 0 money."

        # Assert
        self.assertEqual("Chep has saved 0 money.", actual_result)


if __name__ == "__main__":
    main()
