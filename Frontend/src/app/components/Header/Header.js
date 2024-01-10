import React from 'react'
import Link from 'next/link'
import styles from '@/app/components/Header/header.module.css'

export default function Header() {
    return (
        <header className={`${styles.background} ${styles.titulo}`} >
           
            <ul>
                <li>
                    <Link href="/RotaUm">Recode Turismo (Clique aqui)</Link>
                </li>
                
            </ul>
        </header>
    )
}
