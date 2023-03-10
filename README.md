# ***КОНТРОЛЬАЯ РАБОТА***
## **Исполнитель:** Дегтярев Александр Ярославович

### **Техническое задание:** 

    Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старке выполнения алгоритма.При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### **Описание работы программы:** 

Для выполнения вышеуказанного тз, был выбран вариант клавиатурного/консольного ввода размерности массива, а также его элементов. 

Вначале идет инициализация переменной **"Lenght"**, которая будет отвечать за размерность нашего начального массива. 

    Console.WriteLine("Введите числовое значение размерности массива : ");
    int Length = Math.Abs(int.Parse(Console.ReadLine()));

После чего мы объявляем "начальный" массив **"NewArray"** с типом данных string.
    
    string[] NewArray = new string[Length];


Также инициализируем целочисленную переменную **"count"**. Она поможет нам далее.

    int count = 0;

Создаем цикл **for**, в котором производится заполнение элементов начального массива, пользователем при помощи клавиатуры. В данном цикле, мы также используем условие:   

    if (NewArray[i].Length <= 3) count++;
        
В нем мы обращаемся к свойству массива с типом данных string - **"Lenght"**, благодаря которому мы получаем количество символов конкретного элемента массива. 
Поскольку по условиям задачи, в итоговом массиве должны оказаться лишь элементы первоначального массива, длина который меньше либо равна 3 символам. Так мы заранее можем узнать размерность итогового массива, считая при вводе количество нужных нам элементов, благодаря переменной **"count"** - выходное значение будет использоваться для определения размерности итогового массива.

Выводим получившийся массив для удобства в консоль. Будет легче сравнивать начальный и финальный массив.

Инициализируем итоговый массив **"FinalArray"**, а вместе с ним и вспомогательную переменную **"temp"**.

    string[] FinalArray = new string[count];
    int temp = 0;

Используем еще один цикл **"for"** для того, чтобы записать нужные нам элементы начального массива в итоговый.

    for (int i = 0; i < NewArray.Length; i++)
    {
        if (NewArray[i].Length <= 3)
        {
            FinalArray[temp] = NewArray[i];
            temp++;
        }
    }

Переменная **"temp"**, в нашем случае, отвечает за индекс итогового массива. 

В заключении, выводим итоговый массив **"FinalArray"** на консоль. 

---
## **Примечания к работе**

Описание файлов репозитория:

1. **FTW_Program** - папка с исполнительной программой
2. **.drawio** - блок-схема, поддерживаемая расширением Draw.io integration
3. **.gitignore** - файл с перечнем игнорируемых файлов
4. **block_diagram_jpg.jpg** - блок-схема в формате jpg
5. **README.md** - информация о работе программы и исполнителе

