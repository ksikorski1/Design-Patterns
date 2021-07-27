from __future__ import annotations

from random import uniform

from price_list.observer_pattern.observer import Observer
from price_list.observer_pattern.subject import Subject
from price_list.visitor_pattern.visitor import Visitor
from price_list.visitor_pattern.component import Component
from typing import List


class ProductSeller(Subject, Component):

    _coefficient: float = None
    _observers: List[Observer] = []

    @property
    def coefficient(self):
        return self._coefficient

    def attach(self, observer: Observer) -> None:
        print("ProductSeller: Attached an observer.")
        self._observers.append(observer)

    def detach(self, observer: Observer) -> None:
        self._observers.remove(observer)

    def notify(self) -> None:
        print(f"ProductSeller: Notifying observers... {self._observers}")
        for observer in self._observers:
            observer.update(self)

    def accept(self, visitor: Visitor) -> None:
        visitor.visit_seller(self)

    def change_coefficient(self):
        self._coefficient = uniform(0.5, 2.0)
        print(f"ProductSeller: My coefficient has just changed to: {self._coefficient}")
        self.notify()