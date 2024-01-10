
import styles from './card.module.css';

export default async function Card() {
    const cards = await fetch('http://localhost:5113/GetAll').then(res => res.json());
    


    return (
        <div className={styles.galeria_conteiner}>
             {cards?.map((card) => (
                // <div key={card.id} className={styles.card}>
                //     <div className={styles.card_title}>
                //     <img src={card.img}></img>
                //         <p>Dados vindos da API:</p>
                //         <p>{card.id}</p>
                //         <p>{card.nome}</p>
                //         <p>{card.pais}</p>
                //         <p>{card.estado}</p>
                //         <p>{card.cidade}</p>
                //         <p>{card.valor}</p>
                        
                //     </div>
                // </div>
                <a href="#" className={styles.galeria_lugares}>
                <img src={card.img} alt={card.nome} />
                <h5 className={styles.texto_h2}>{card.nome}</h5>
              </a>
                
             ))}
        </div>
    )
}