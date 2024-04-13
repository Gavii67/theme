.card {
  width: 300px;
  height: 400px;
  perspective: 1000px; /* Creates the perspective */
}

.card-inner {
  width: 100%;
  height: 100%;
  transition: transform 0.5s;
  transform-style: preserve-3d; /* Allows children to exist in 3D space */
  cursor: pointer;
}

.card:hover .card-inner {
  transform: rotateY(180deg); /* Rotates the card on hover */
}

.front, .back {
  position: absolute;
  width: 100%;
  height: 100%;
  backface-visibility: hidden; /* Hides the back side of the card when facing away */
}

.front {
  background: url('front.jpg') no-repeat center / cover; /* Front side image */
}

.back {
  background: url('back.jpg') no-repeat center / cover; /* Back side image */
  transform: rotateY(180deg); /* Initially rotated to be the back */
}
