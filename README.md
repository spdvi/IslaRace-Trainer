# IslaRace-Trainer
· Game Objects: Main camera, Directional light, Primitives. 
· Adding game objects to the Scene. Afegir un cub.
· Moving around the scene, focusing GameObjects
· Components. Transform, Mesh renderer. Tools... Texture, color, Materials
· Modify the cube transform.

· Afegir un Plane i fer el suelo. Descarregar una textura seamless, crear un material a partir de la textura i afegir-lo al suelo.

· Crear Empty GameObject Player.
· Afegir una capsule com a body i dos spheres pels ulls.
· Modificar la escala z de la capsula
· Afegir un material i donar color a la capsula i spheres
· Exercici: afegir blocs alrededor del stage (almena). Ctrl+D. Ctrl+Move (snap to grid)

· Convertir el bloc almena a prefab??

· Primer script: MovePlayer. MonoBehaviour, Start, Update. Crear el script sense asociar-lo a cap GameObject. Debug.log, compilar i Play. Comprobar que no apareix res. Associar el MovePlayer al Player.
· Codificar el moviment del player en el plano XZ amb Input GetAxis. Translate & Rotate.  Time.deltaTime
· Afegir variable per controlar la velocitat desde el Inspector.
· Exercici: afegir spinner i altres obstacles a la scene.

· Afegir un podium meta. Intentar pujar. Remove capsule collider.
· Asset Store: purchase, download, import Wooden Crates Animation Arts Creative G. Place a crate in the Scene.

· Move over the crate. Modify the prefabs and add a collider to the lid and to the crate.

. Camera follow: referències a GameObjects des de scripts. Smooth camera LateUpdate

. Jump: Afegir Rigidbody. Constraint X,Y,Z rotation. Nou script, Input Space, AddForce Impulse. IsGrounded
· En Play mode canviar a Scene Window

· Tocar el bloc amb el cap al saltar. Canvia de color de red a verd. Desbloqueja porta tresor. Script pujar porta. Comunicació entre scripts.

· Instantiate meteorits que cauen cap al player
· Descarregar food assets de kenney. FBX convertir-los a prefab.
· Afegir colliders i modificar tamany i posició.
· Afegir rigidbody.
· Crear script FoodSpawner. Codificarlo. Calcular punt de llançament de la comida random. Array de GameObjects per comida. Cached refs. Triar una comida random. Calcular vector dirección al player. Aplicar una força al rb del food. Jugar amb les direfents tipus de forces, amb la gravetat Physics.gravity, amb use gravity true false, amb el módul de la força, etc. per obtenir un efecte realista desitjat.
· Crear script DestroyFood. Associarlo al floor. Afegir tags als elements food. Detectar que ha collisionat amb el floor i eliminarlo als 3s.