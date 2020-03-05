## Хранитель (Memento)
Паттерн **Хранитель (Memento)** позволяет выносить внутреннее состояние объекта за его пределы для последующего возможного восстановления объекта без нарушения принципа инкапсуляции.

**Когда использовать Memento?**

* Когда нужно сохранить состояние объекта для возможного последующего восстановления

* Когда сохранение состояния должно проходить без нарушения принципа инкапсуляции

То есть ключевыми понятиями для данного паттерна являются **сохранение внутреннего состояния** и **инкапсуляция**, и важно соблюсти баланс между ними. Ведь, как правило, если мы не нарушаем инкапсуляцию, то состояние объекта хранится в объекте в приватных переменных. И не всегда для доступа к этим переменным есть методы или свойства с сеттерами и геттерами. Например, в игре происходит управление героем, все состояние которого заключено в нем самом - оружие героя, показатель жизней, силы, какие-то другие показатели. И нередко может возникнуть ситуация, сохранить все эти показатели во вне, чтобы в будущем можно было откатиться к предыдущему уровню и начать игру заново. В этом случае как раз и может помочь паттерн Хранитель.

**Участники**
* **Memento**: хранитель, который сохраняет состояние объекта Originator и предоставляет полный доступ только этому объекту Originator

* **Originator**: создает объект хранителя для сохранения своего состояния

* **Caretaker**: выполняет только функцию хранения объекта Memento, в то же время у него нет полного доступа к хранителю и никаких других операций над хранителем, кроме собственно сохранения, он не производит
***
Использование паттерна Memento дает нам следующие **преимущества**:

* Уменьшение связанности системы

* Сохранение инкапсуляции информации

* Определение простого интерфейса для сохранения и восстановления состояния


В то же время мы можем столкнуться с **недостатками**, в частности, если требуется сохранение большого объема информации, то возрастут издержки на хранение всего объема состояния.