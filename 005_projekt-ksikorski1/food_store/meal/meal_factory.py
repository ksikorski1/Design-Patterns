from abc import abstractmethod, ABC


class MealFactory(ABC):
    @abstractmethod
    def prepare_meal(self):
        pass
