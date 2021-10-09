# Interfaces Inteligentes - Práctica 01

![holi](img/II2122-P01.gif)

En esta práctica de introducción a Unity, se ha realizado una escena con elementos 3D básicos utilizando el editor de escenas integrado con el motor gráfico.

Esta escena incluye objetos desde primitivas 3D sencillas hasta assets de una mayor complejidad, descargados desde la Unity Asset Store. Se ha utilizado un terreno para dar forma al espacio disponible para la movilidad del jugador, añadiendo elementos requeridos en el guión de la práctica como una fuente de agua o una segunda luz a la escena.

En cuanto a scripting se refiere, se desarrolló una funcionalidad sencilla que se encuentra asociada a cada uno de los objetos instanciados en la escena. Este script, [incluido en el repositorio de esta práctica](./Whoami.cs), muestra un mensaje en la consola de depuración de Unity en cada frame de ejecución. Este texto incluye el nombre, etiqueta e ID (asignado manualmente) del objeto invocante, así como el número de veces que el mensaje ha sido mostrado por consola durante el tiempo de ejecución.