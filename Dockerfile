FROM bitnami/postgresql:15-apline

# Настройка пользователя и пароля для базы данных
ENV POSTGRES_USER=user
ENV POSTGRES_PASSWORD=password

# Настройка имени базы данных
ENV POSTGRES_DB=cars_db
