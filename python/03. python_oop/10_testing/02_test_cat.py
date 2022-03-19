class Cat:

  def __init__(self, name):
    self.name = name
    self.fed = False
    self.sleepy = False
    self.size = 0

  def eat(self):
    if self.fed:
      raise Exception('Already fed.')

    self.fed = True
    self.sleepy = True
    self.size += 1

  def sleep(self):
    if not self.fed:
      raise Exception('Cannot sleep while hungry')

    self.sleepy = False


from unittest import TestCase, main


class CatTest(TestCase):
    def setUp(self):
        self.cat = Cat("Sharo")

    # def test_init_creates_all_attributes(self):
    #     cat = self.cat
        # self.assertEqual("Sharo", cat.name)
        # self.assertEqual(False, cat.sleepy)
        # self.assertEqual(False, cat.fed)
        # self.assertEqual(0, cat.size)

    def test_cat_size_is_increased_after_eating(self):
        cat = self.cat
        self.assertEqual(0, cat.size)
        cat.eat()
        self.assertEqual(1, cat.size)

    def test_cat_is_fed_after_eating(self):
        cat = self.cat
        self.assertEqual(False, cat.fed)
        cat.eat()
        self.assertEqual(True, cat.fed)


    def test_cat_can_not_eat_if_fed_raises(self):
        cat = self.cat
        self.assertEqual(False, cat.fed)
        cat.eat()
        self.assertEqual(True, cat.fed)

        with self.assertRaises(Exception) as ex:
            cat.eat()

        self.assertEqual("Already fed.", str(ex.exception))

    def test_cat_can_not_fall_asleep_if_not_fed_raises(self):
        cat = self.cat
        self.assertEqual(False, cat.fed)

        with self.assertRaises(Exception) as ex:
            cat.sleep()

        self.assertEqual("Cannot sleep while hungry", str(ex.exception))

    def test_cat_is_not_sleepy_after_sleep(self):
        cat = self.cat
        self.assertEqual(False, self.cat.sleepy)
        self.cat.eat()
        self.assertEqual(True, self.cat.sleepy)
        self.cat.sleep()
        self.assertEqual(False, self.cat.sleepy)


if __name__ == "__main__":
    main()


