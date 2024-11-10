import React, { useState } from "react";
import PokemonModal from "./PokemonModal";

function PokemonTable({ pokemonList }) {
    const [selectedPokemon, setSelectedPokemon] = useState(null);
  
    return (
      <div>
        <table className="table table-striped table-hover">
          <thead className="table-dark">
            <tr>
              <th>Nome</th>
              <th>Região</th>
            </tr>
          </thead>
          <tbody>
            {pokemonList.map((pokemon) => (
              <tr key={pokemon.id} onClick={() => setSelectedPokemon(pokemon)}>
                <td>{pokemon.pokemon}</td>
                <td>{pokemon.regiao.regiao}</td>
              </tr>
            ))}
          </tbody>
        </table>
        {selectedPokemon && (
          <PokemonModal
            pokemon={selectedPokemon}
            onClose={() => setSelectedPokemon(null)}
          />
        )}
      </div>
    );
  }
  
  export default PokemonTable;