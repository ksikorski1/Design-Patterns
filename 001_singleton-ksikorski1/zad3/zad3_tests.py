import pickle, threading
from zad3_serialization import *

def test_serialization1():
    s1 = SingletonClassOptimized()
    deserialized = pickle.dumps(s1)
    serialized = pickle.loads(deserialized)
    #assert (s1 == serialized)
    print ("", s1, "\n", serialized)

def test_serialization2():
    s1 = Singleton()
    deserialized = pickle.dumps(s1)
    serialized = pickle.loads(deserialized)
    print ("", s1, "\n", serialized)


if __name__ == "__main__":
    #Singleton class optimized (metaclass)
    process1 = threading.Thread(target=test_serialization1)
    process2 = threading.Thread(target=test_serialization1)
    process1.start()
    process2.start()

    #Singleton with __new__
    process3 = threading.Thread(target=test_serialization2)
    process4 = threading.Thread(target=test_serialization2)
    process3.start()
    process4.start()