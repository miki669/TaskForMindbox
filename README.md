# TaskForMindbox
Задача была написана для компании MindBox

#Сircle
>![image](https://user-images.githubusercontent.com/81651689/206321232-ec5082c7-848c-4074-8b89-7ed46e91e9ab.png)

#Triangle
>![image](https://user-images.githubusercontent.com/81651689/206321305-d9c82b79-4fb7-4357-9199-6bac4046e280.png)


#В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

<code>
SELECT prod.name [продукт], cat.name [категория] FROM Products prod
    LEFT FOIN ProdCat prodcat ON prod.id = prodcat.products_id
    INNER JOIN Category cat ON cat.id = prodcat.category_id
ORDER BY prod.name;
 </code>
