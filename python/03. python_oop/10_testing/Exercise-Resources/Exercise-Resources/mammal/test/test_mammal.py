from unittest import TestCase, main
from project.mammal import Mammal


class MammalTest(TestCase):
    def setUp(self):
        self.mammal = Mammal("Vihar", "Dog", "Bark")

    def test_mammal_is_initialising_correctly(self):
        mammal = self.mammal

        self.assertEqual("Vihar", mammal.name)
        self.assertEqual("Dog", mammal.type)
        self.assertEqual("Bark", mammal.sound)

    def test_make_sound(self):
        mammal = self.mammal
        self.assertEqual("Vihar makes Bark", mammal.make_sound())

    # get_kingdom return self.__kingdom

    def test_get_kingdom(self):
        self.assertEqual(self.mammal._Mammal__kingdom, self.mammal.get_kingdom())

    #     def info(self):
    #         return f"{self.name} is of type {self.type}"

    def test_info(self):
        self.assertEqual("Vihar is of type Dog", self.mammal.info())

if __name__ == "__main__":
    main()

