from abc import abstractmethod, ABC

from  dish.dish import Dish


class DumplingAbstract(Dish, ABC):
    @property
    def name(self) -> str:
        return 'Dumpling'

    @property
    @abstractmethod
    def country(self):
        pass
