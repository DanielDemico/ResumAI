function PokemonCard({ name, url}) {

    const id = url.split('/')[6];
    const imageUrl = `https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${id}.png`;

    return(
        <div style={{border: '1px solid #ccc', padding:'10px'}}>
            <img src='{imgUrl}'></img>
            <p> {name} </p>
        </div>
    );
}
export default PokemonCard;