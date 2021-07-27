from  dish.dish_factory import DishFactory
from  dish.spaghetti.spaghetti import Spaghetti
from  singleton_meta import SingletonMeta


class SpaghettiFactory(DishFactory, metaclass=SingletonMeta):

    def prepare(self, count: int = 1, vegetarian: bool = False) -> Spaghetti:
        return Spaghetti(count, vegetarian)