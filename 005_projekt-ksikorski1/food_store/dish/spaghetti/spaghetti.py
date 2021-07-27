from  dish.spaghetti.spaghetti_abstract import SpaghettiAbstract


class Spaghetti(SpaghettiAbstract):
    @property
    def country(self) -> str:
        return 'Italy'

    @property
    def profit(self) -> float:
        return 1.3
