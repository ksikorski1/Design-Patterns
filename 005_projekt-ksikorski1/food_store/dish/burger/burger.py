from dish.burger.burger_abstract import BurgerAbstract


class Burger(BurgerAbstract):
    @property
    def country(self) -> str:
        return 'USA'

    @property
    def profit(self) -> float:
        return 1.15