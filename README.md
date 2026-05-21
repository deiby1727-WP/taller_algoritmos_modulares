# Sistema Integrado de Gestión en C# (Consola)

Este proyecto contiene un sistema de consola desarrollado en C# que integra tres módulos principales:

- Sistema de control de turnos para una IPS
- Sistema de control académico de estudiantes
- Sistema de control de parqueadero para conjunto residencial

---

## Estructura del proyecto

El proyecto está organizado en las siguientes clases:

- Program.cs → Menú principal del sistema
- punto1.cs → Sistema IPS (registro y control de pacientes)
- punto3.cs → Sistema académico (registro y análisis de notas)
- punto4.cs → Sistema de parqueadero (control de vehículos)

---

## Funcionalidades

### Sistema IPS
- Registro de pacientes
- Consulta de pacientes
- Búsqueda por documento
- Clasificación por tipo de atención
- Identificación de prioridad

---

### Sistema Académico
- Registro de estudiantes
- Ingreso de notas (3 notas por estudiante)
- Cálculo de promedio
- Estado académico (Aprobado / Habilita / Reprueba)
- Promedio general del curso
- Mayor y menor promedio

---

### Sistema de Parqueadero
- Registro de vehículos
- Validación de placas
- Control de hora de ingreso y salida
- Cálculo de tiempo de permanencia
- Clasificación por tipo de vehículo
- Vehículo con mayor tiempo de permanencia
