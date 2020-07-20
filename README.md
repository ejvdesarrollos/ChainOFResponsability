# ChainOFResponsability

Patrón de comportamiento

Permite definir:
1. Interfaz para comportamientos
2. Tantas clases como niveles de jerarquía por los que puede pasar si el nivel anterior no puede resolverlo.
3. En el constructor se plantea quién es el siguiente en la cadena.
4. El objetivo es que las clases si no pueden resolverlo se lo deleguen al siguiente.
