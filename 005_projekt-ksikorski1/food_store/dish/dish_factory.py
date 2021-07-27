from abc import ABC, abstractmethod

from  singleton_meta import SingletonMeta


class DishFactory(ABC, metaclass=SingletonMeta):

    @abstractmethod
    def prepare(self, count, vegetarian):
        pass