# this project is being createde for learning purpose only


#we have two assembly :
1. MyFirstApp - an console app
2. MyClassLibrary -> an class Library project

#Referencing the Class libaray in to MyFirstApp 
dotnet add ../MyClassLibrary/MyClassLibrary.csproj


MyFirstApp:



-collections
    - WorkingWithLIst
        1. Explain about different list number, String and Class type
        2. Differetn way of declaring the list and initializing it like 
            a.     List<int> number = List<int>(); 
            b.     List<int> number = [1,2,3,4,5,6];
            c.     List<Product> product = new List<Product>{ new Product{id=1, name="mobile", Price=12}};
            
        3. Different method of list like Add(), Removed(), RemoveAt(), Any(predicate), FindAll(predicate),Sort()
        4. differet way to access the list value like - foreach, listName.Foreach(), for() loop, using GetEnumrator() and Next(),  Strin.Join(" ", ListName.ToArray())
        5. Filter list items using LINQ

-OOPs-Concept

    - nullablePractice
        -nullable is created using ?
        -it has different method like HasValue, Value etc.
        -if an integer is declare as nullable then we can not use directly that variable to any int operation. we  
         have to use VariableName.Value.
        -use case is: when dealing with 1. database interaction or 2. Form data

