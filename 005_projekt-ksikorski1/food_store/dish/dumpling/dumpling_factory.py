from  dish.dish_factory import DishFactory
from  dish.dumpling.dumpling import Dumpling
from  singleton_meta import SingletonMeta


class DumplingFactory(DishFactory, metaclass=SingletonMeta):

    def prepare(self, count: int = 1, vegetarian: bool = True) -> Dumpling:
        return Dumpling(count, vegetarian)