Primero he creado un script para cada Particle que establece todas las variables que va a necesitar esa partícula.
Despues he creado otro script, que haciendo referiencia al primer script genera particlas con valores aleatorios, dentro de un timer de spawn que yo determino.
Ahora vuelvo al primer script y hago que cada particlua se encarge de actualizar su propia posición, asi como eliminarse a si misma.
La escena es SampleScene, ignora el script de AddForce.
