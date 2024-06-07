class Persona:

    #empiezo asignando los parametros de la primera clase
    def __init__(self, nombre, edad):
        self.nombres = nombre
        self.edad = edad

    #Seguidamente construyo mi siguiente clase la cual va a heredar los parametros de clase persona
    #añadiendole un parametro nuevo, este va a ser la universidad del estudiante
class Estudiante(Persona):
    def __init__(self, nombre, edad, universidad):
        super().__init__(nombre, edad)
        self.universidad = universidad

print(Persona, "toti", "18", "unermb") 
    #utilizo el nombre de la clase principal asignandole nombre a cada instancia para imprimir cada dato

    #procedo a crear otra clase la cual va a heredar la clase persona pero en este caso
    # sera para profesor y es para la asignaturav del profesor  
class Profesor: 
    def __init__(self,nombre, edad, asignatura):
        super().__init__(nombre, edad)
        self.asignatura = asignatura
    
print(Profesor, "cindy", "25", "calculo")
    #tal y como en la clase anterior utilizo el nombre de la clase y le asigno nombre a cada
    #instancia para poder imprimirlo


    #por ultimo creo una clase una llamada curso la cual contiene los nombres de los estudiantes
    #en la cual tambien puedo agregar mas personas de ser el caso
class Curso:
    def __init__(self, nombres):
        self.nombres = nombres

    lista = ["Juan","Yo","Williams", "Richerly"]

    #añadir
    lista.append("alguien")

    #imprimir lista completa
    print(lista)

    

