package com.josemeurer.springSecurity_jwt.dto;

import java.time.Instant;

public record HelloDTO(String message, Instant timestamp) {
}
