.stuffed-animal {
  width: 100px;
  height: 100px;
  margin: 20px;
  border-radius: 50%;
  background-image: url("teddy-bear.png"); /* teddy bear image */
  background-size: cover;
  /* agregar animación de zoom */
  animation: zoom 3s linear infinite;
}

.flower {
  width: 50px;
  height: 50px;
  margin: 10px;
  border-radius: 50%;
  background-image: url("flower.png"); /* flower image */
  background-size: cover;
  /* agregar animación de zoom */
  animation: zoom 2s linear infinite;
}

@keyframes zoom {
  0% {
    transform: scale(0.8);
  }
  100% {
    transform: scale(1.2);
  }
}