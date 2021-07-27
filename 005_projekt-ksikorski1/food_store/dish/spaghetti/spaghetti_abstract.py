from abc import abstractmethod, ABC

from  dish.dish import Dish


class SpaghettiAbstract(Dish, ABC):
    @property
    def name(self) -> str:
        return 'Spaghetti'

    @property
    @abstractmethod
    def country(self):
        pass
