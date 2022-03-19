
from unittest import TestCase, main

class MammalTest(TestCase):
    def setUp(self):
        self.mammal = Mammal("Vihar", "Dog", "Bark")

    def test_mammal_is_initialising_correctly(self):
        mammal = self.mammal

        # Assert
        self.assertEqual("Vihar", mammal.name)
        self.assertEqual("Dog", mammal.type)
        self.assertEqual("Bark", mammal.sound)




if __name__ == "__main__":
    main()

