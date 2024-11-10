import React from "react";
import { Modal, Button } from "react-bootstrap";

function PokemonModal({ pokemon, onClose }) {
  return (
    <Modal show={true} onHide={onClose} centered>
      <Modal.Header closeButton>
        <Modal.Title>{pokemon.pokemon}</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <p><strong>Tipo:</strong> {pokemon.tipo}</p>
        <p><strong>Status:</strong> {pokemon.status}</p>
        <p><strong>Fraquezas:</strong> {pokemon.fraquesas}</p>
        <p><strong>Pontos Fortes:</strong> {pokemon.pontosFortes}</p>
      </Modal.Body>
      <Modal.Footer>
        <Button variant="secondary" onClick={onClose}>
          Fechar
        </Button>
      </Modal.Footer>
    </Modal>
  );
}

export default PokemonModal;

