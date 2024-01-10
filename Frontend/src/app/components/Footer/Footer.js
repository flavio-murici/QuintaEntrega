import React from 'react'
import styles from '@/app/components/Footer/footer.module.css'

export default function Footer() {
  return (
    <footer className={`${styles.background} ${styles.titulo}`}>
      &copy; 2024 Flávio Alexandre. Todos os direitos reservados.
    </footer>
  )
}
