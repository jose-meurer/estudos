INSERT INTO roles(authority) VALUES ('ROLE_USER');
INSERT INTO roles(authority) VALUES ('ROLE_ADMIN');

INSERT INTO users(username, password) VALUES ('user', '$2a$10$PpOr85NrWJYx7Ww.iUmv3uChQBggECfG4LoeaSd3TbYEbHUebvSAO');
INSERT INTO users(username, password) VALUES ('admin', '$2a$10$PpOr85NrWJYx7Ww.iUmv3uChQBggECfG4LoeaSd3TbYEbHUebvSAO');

INSERT INTO user_roles(user_id, role_id) VALUES (1, 1);
-- INSERT INTO user_roles(user_id, role_id) VALUES (2, 1);
INSERT INTO user_roles(user_id, role_id) VALUES (2, 2);