Logo GB.png

# Итоговая проверочная работа

## _**Задание**_
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе **```Разработчик```**. Мы должны убедиться, что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:
```
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
```
***

## _**Комментарии по выполнению**_

### **Кратко по контролю версий**

Для удаленного хранения проекта и работы над ним выбран хостинг __*GitHub*__, работа с которым осуществляется посредством системы управления версиями __*Git*__. 

Связывание созданного на сервере GitHub и локального репозиториев производилось с помощью команды __*git remote add*__.

Все изменения, вносимые в проект, коммитились и выгружались с локального на удаленный репозиторий командой __*git push*__.

В данном случае вся работа производилась в главной ветке **main**, разветвление не использовалось.
***

### **Кратко по блок-схеме**

Отрисовка блок-схемы производилась в программе **draw.io**.

В качестве входящих данных используется строковый массив.

В первой части блок-схемы отображен алгоритм нахождения размерности итогового массива, содержащего элементы входящего строкового массива, не превышающие 3 символа.

Во второй части блок-схемы происходит пошаговая сортировка элементов входящего массива с копированием их поочередно в итоговый массив.

Следующим этапом входящий и итоговый массивы выводятся на печать.
***

### **Описание решения**

Суть задачи состоит в нахождении в заданном строковом массиве элементов, длина которых не превышает 3 символа, и создании из этих элементов нового массива.

Для решения были написаны и использовались следующие методы:
- __*FillStringArray*__ - для заполнения массива данными
- __*GetMaxThreeSymbElemArray*__ - для определения размерности итогового массива и заполнения его отсортированными элементами
- __*PrintArray*__ - для вывода массива на экран

    
#### **`Метод FillStringArray`**

Данный метод позволяет поочередно ввести элементы в строковый массив определенной размерности, указанной пользователем в основном теле программы. 

#### **`Метод GetMaxThreeSymbElemArray`**

Данный метод сначала находит длину итогового массива посредством перебора элементов заданного массива на соблюдение условия, указанного в задании (длина строкового элемента менее или равно 3 символам).

Следующим этапом в данном методе повторным перебором на соблюдение этого же условия определяются искомые элементы и последовательно записываются в итоговый массив.

#### **`Метод PrintArray`**

Данный метод позволяет вывести массив на экран. Метод используется для вывода заданного и итогового массивов. В случае отсутствия в заданном массиве искомых элементов выводятся просто квадратные скобки.