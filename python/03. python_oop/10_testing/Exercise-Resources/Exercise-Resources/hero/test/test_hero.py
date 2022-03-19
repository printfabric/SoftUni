from project.hero import Hero
from unittest import TestCase, main


class TestHero(TestCase):
    def setUp(self):
        self.hero = Hero("Spiro", 10, 200.0, 100.0)
        self.enemy_hero = Hero("Miro", 10, 200.0, 100.0)

    def test_class_attribute_types(self):
        hero = self.hero
        self.assertEqual(type(hero.username), str)
        self.assertEqual(type(hero.health), float)
        self.assertEqual(type(hero.damage), float)
        self.assertEqual(type(hero.level), int)

    def test_hero_is_initialising_correctly(self):
        hero = self.hero
        self.assertEqual(hero.username, "Spiro")
        self.assertEqual(hero.level, 10)
        self.assertEqual(hero.health, 200)
        self.assertEqual(hero.damage, 100)

    def test_battle_is_enemy_hero_name_same_as_hero_name(self):
        hero = self.hero
        enemy_hero = Hero("Spiro", 10, 200, 100)

        with self.assertRaises(Exception) as ex:
            hero.battle(enemy_hero)
        self.assertEqual(str(ex.exception), "You cannot fight yourself")

    def test_battle_is_health_bellow_one_raise_error(self):
        hero = Hero("Spiro", 10, 0, 200)
        enemy_hero = Hero("Miro", 10, 100, 200)

        with self.assertRaises(Exception) as ex:
            hero.battle(enemy_hero)
        self.assertEqual(str(ex.exception), "Your health is lower than or equal to 0. You need to rest")

    def test_battle_is_enemy_hero_health_bellow_minimum_raise_error(self):
        hero = Hero("Spiro", 10, 100, 200)
        enemy_hero = Hero("Miro", 10, 0, 200)

        with self.assertRaises(Exception) as ex:
            hero.battle(enemy_hero)
        self.assertEqual(str(ex.exception), f"You cannot fight {enemy_hero.username}. He needs to rest")

    def test_battle_hero_health_after_battle(self):
        hero = self.hero
        enemy_hero = self.enemy_hero

        hero.battle(enemy_hero)
        self.assertEqual(hero.health, -800)
        self.assertEqual(enemy_hero.health, -800)

    def test_battle_both_heroes_below_minimum_health(self):
        hero = Hero("Spiro", 10, 200, 100)
        enemy_hero = Hero("Miro", 10, 200, 100)

        self.assertEqual(hero.battle(enemy_hero), "Draw")

    def test_battle_hero_win(self):
        hero = Hero("Spiro", 1, 200, 200)
        enemy_hero = Hero("Miro", 1, 200, 100)

        self.assertEqual(hero.battle(enemy_hero), "You win")
        self.assertEqual(hero.level, 2)
        self.assertEqual(hero.health, 105)
        self.assertEqual(hero.damage, 205)

    def test_battle_enemy_hero_win(self):
        hero = Hero("Spiro", 1, 200, 100)
        enemy_hero = Hero("Miro", 1, 200, 200)

        self.assertEqual(hero.battle(enemy_hero), "You lose")
        self.assertEqual(enemy_hero.level, 2)
        self.assertEqual(enemy_hero.health, 105)
        self.assertEqual(enemy_hero.damage, 205)

    def test_str(self):
        hero = self.hero
        res = f"Hero {hero.username}: {hero.level} lvl\nHealth: {hero.health}\nDamage: {hero.damage}\n"
        self.assertEqual(res, str(hero))


if __name__ == "__main__":
    main()

