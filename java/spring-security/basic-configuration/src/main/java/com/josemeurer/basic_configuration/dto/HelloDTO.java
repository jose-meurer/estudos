package com.josemeurer.basic_configuration.dto;

import java.time.Instant;

public record HelloDTO(String message, Instant timestamp) {
}
