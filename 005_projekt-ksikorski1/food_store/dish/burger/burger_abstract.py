from abc import abstractmethod, ABC

from  dish.dish import Dish


class BurgerAbstract(Dish, ABC):
    @property
    def name(self) -> str:
        return 'Burger'

    @property
    @abstractmethod
    def country(self):
        pass
