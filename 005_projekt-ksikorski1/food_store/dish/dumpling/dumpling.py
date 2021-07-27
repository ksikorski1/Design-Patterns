from  dish.dumpling.dumpling_abstract import DumplingAbstract


class Dumpling(DumplingAbstract):
    @property
    def country(self) -> str:
        return 'Poland'

    @property
    def profit(self) -> float:
        return 1.5
