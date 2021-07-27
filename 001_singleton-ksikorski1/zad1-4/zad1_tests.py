from zad1_threading import *
from timeit import timeit
from threading import Thread, current_thread

def test_singleton():
    print(current_thread())
    singleton1 = SingletonClassOptimized()
    singleton2 = SingletonClassOptimized()
    assert(singleton1 == singleton2)
    print(singleton1, singleton2)

def test_singleton_thread_local():
    print(current_thread())
    singleton1 = SingletonClassThreadLocal()
    singleton2 = SingletonClassThreadLocal()
    assert(singleton1 == singleton2)
    print(singleton1, singleton2)

if __name__ == "__main__":

    process1 = Thread(target=test_singleton)
    process2 = Thread(target=test_singleton)
    process1.start()
    process2.start()

    process1local = Thread(target=test_singleton_thread_local)
    process1local.start()
    process2local = Thread(target=test_singleton_thread_local)
    process2local.start()

    print("Time Singleton: %.4f" %timeit('SingletonClass()', globals=globals(), number=10000000))
    print("Time SingletonOptimized: %.4f" %timeit('SingletonClassOptimized()', globals=globals(), number=10000000))