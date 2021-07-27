
class Price:
    def __init__(self) -> None:
        self._base = 0
        self._profit = 0
        self._net = 0
        self._gross = 0
        self._fare = 0

    @property
    def __repr__(self) -> float:
        return self._gross

    @property
    def gross(self) -> float:
        return self._gross

    @property
    def net(self) -> float:
        return self._net

    @property
    def fare(self) -> float:
        return self._fare
