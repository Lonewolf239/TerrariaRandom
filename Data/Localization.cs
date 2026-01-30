namespace TerrariaRandomizer.Data;

public static class Localization
{
    private static readonly Dictionary<string, string> LangNames = new()
    {
        ["en"] = "English",
        ["ru"] = "Русский",
        ["es"] = "Español",
        ["de"] = "Deutsch",
        ["fr"] = "Français",
        ["pl"] = "Polski",
        ["pt"] = "Português",
        ["it"] = "Italiano",
        ["tr"] = "Türkçe"
    };

    private static readonly Dictionary<string, string> NameToCode = LangNames.ToDictionary(kvp => kvp.Value.ToLower(), kvp => kvp.Key);

    private static readonly Dictionary<string, Dictionary<string, string>> Localizations = new()
    {
        ["Parameters.Language.Error"] = new()
        {
            ["en"] = "Unsupported language specified.",
            ["ru"] = "Указан неподдерживаемый язык.",
            ["es"] = "Idioma no soportado especificado.",
            ["de"] = "Nicht unterstützte Sprache angegeben.",
            ["fr"] = "Langue non prise en charge spécifiée.",
            ["pl"] = "Określony język nie jest obsługiwany.",
            ["pt"] = "Idioma não suportado especificado.",
            ["it"] = "Lingua non supportata specificata.",
            ["tr"] = "Desteklenmeyen dil belirtildi."
        },
        ["Parameters.Count.Error"] = new()
        {
            ["en"] = "--count: maximum value is 12!",
            ["ru"] = "--count: максимальное значение 12!",
            ["es"] = "--count: ¡valor máximo es 12!",
            ["de"] = "--count: Maximalwert ist 12!",
            ["fr"] = "--count : valeur maximale est 12 !",
            ["pl"] = "--count: maksymalna wartość to 12!",
            ["pt"] = "--count: valor máximo é 12!",
            ["it"] = "--count: valore massimo è 12!",
            ["tr"] = "--count: maksimum değer 12!"
        },
        ["Parameters.MaxAnimationFrames.Error"] = new()
        {
            ["en"] = "Minimum value for --maxAnimationFrames is 55!",
            ["ru"] = "Минимальное значение для --maxAnimationFrames равно 55!",
            ["es"] = "¡El valor mínimo para --maxAnimationFrames es 55!",
            ["de"] = "Mindestwert für --maxAnimationFrames ist 55!",
            ["fr"] = "Valeur minimale pour --maxAnimationFrames est 55 !",
            ["pl"] = "Minimalna wartość dla --maxAnimationFrames to 55!",
            ["pt"] = "Valor mínimo para --maxAnimationFrames é 55!",
            ["it"] = "Valore minimo per --maxAnimationFrames è 55!",
            ["tr"] = "--maxAnimationFrames için minimum değer 55!"
        },
        ["Parameters.Only.Error"] = new()
        {
            ["en"] = "You cannot use --onlyVanilla and --onlyCalamity at the same time!",
            ["ru"] = "Нельзя использовать --onlyVanilla и --onlyCalamity одновременно!",
            ["es"] = "¡No puedes usar --onlyVanilla y --onlyCalamity al mismo tiempo!",
            ["de"] = "Du kannst --onlyVanilla und --onlyCalamity nicht gleichzeitig verwenden!",
            ["fr"] = "Vous ne pouvez pas utiliser --onlyVanilla et --onlyCalamity en même temps !",
            ["pl"] = "Nie możesz używać --onlyVanilla i --onlyCalamity jednocześnie!",
            ["pt"] = "Você não pode usar --onlyVanilla e --onlyCalamity ao mesmo tempo!",
            ["it"] = "Non puoi usare --onlyVanilla e --onlyCalamity contemporaneamente!",
            ["tr"] = "--onlyVanilla ve --onlyCalamity'yi aynı anda kullanamazsın!"
        },
        ["Parameters.InvalidClasses.Error"] = new()
        {
            ["en"] = "Invalid classes: ",
            ["ru"] = "Неверные классы: ",
            ["es"] = "Clases inválidas: ",
            ["de"] = "Ungültige Klassen: ",
            ["fr"] = "Classes invalides : ",
            ["pl"] = "Nieprawidłowe klasy: ",
            ["pt"] = "Classes inválidas: ",
            ["it"] = "Classi non valide: ",
            ["tr"] = "Geçersiz sınıflar: "
        },
        ["Parameters.AllClassesDisabled.Error"] = new()
        {
            ["en"] = "Cannot disable all classes! At least one class must remain enabled.",
            ["ru"] = "Нельзя отключить все классы! Должен остаться хотя бы один включённый класс.",
            ["es"] = "¡No se pueden desactivar todas las clases! Debe quedar al menos una clase activada.",
            ["de"] = "Alle Klassen können nicht deaktiviert werden! Mindestens eine Klasse muss aktiviert bleiben.",
            ["fr"] = "Impossible de désactiver toutes les classes ! Au moins une classe doit rester activée.",
            ["pl"] = "Nie można wyłączyć wszystkich klas! Przynajmniej jedna klasa musi pozostać włączona.",
            ["pt"] = "Não é possível desativar todas as classes! Pelo menos uma classe deve permanecer ativada.",
            ["it"] = "Non puoi disabilitare tutte le classi! Almeno una classe deve rimanere abilitata.",
            ["tr"] = "Tüm sınıfları devre dışı bırakamazsın! En az bir sınıf etkin kalmalı."
        },
        ["Parameters.InvalidInput.Error"] = new()
        {
            ["en"] = "The parameters were entered incorrectly. Use --help for help.",
            ["ru"] = "Параметры введены неверно. Используйте --help для справки.",
            ["es"] = "Los parámetros se introdujeron incorrectamente. Usa --help para ayuda.",
            ["de"] = "Die Parameter wurden falsch eingegeben. Verwende --help für Hilfe.",
            ["fr"] = "Les paramètres ont été saisis incorrectement. Utilisez --help pour l'aide.",
            ["pl"] = "Parametry wprowadzono nieprawidłowo. Użyj --help po pomoc.",
            ["pt"] = "Os parâmetros foram inseridos incorretamente. Use --help para ajuda.",
            ["it"] = "I parametri sono stati inseriti incorrectamente. Usa --help per aiuto.",
            ["tr"] = "Parametreler yanlış girildi. Yardım için --help kullan."
        },
        ["Parameters.Classes.Error"] = new()
        {
            ["en"] = "Cannot use --disableClasses and --enableClasses simultaneously",
            ["ru"] = "Нельзя использовать --disableClasses и --enableClasses одновременно",
            ["es"] = "No se pueden usar --disableClasses y --enableClasses simultáneamente",
            ["de"] = "Cannot use --disableClasses and --enableClasses simultaneously",
            ["fr"] = "Impossible d'utiliser --disableClasses et --enableClasses simultanément",
            ["pl"] = "Nie można używać --disableClasses i --enableClasses jednocześnie",
            ["pt"] = "Não é possível usar --disableClasses e --enableClasses simultaneamente",
            ["it"] = "Impossibile usare --disableClasses e --enableClasses contemporaneamente",
            ["tr"] = "--disableClasses ve --enableClasses aynı anda kullanılamaz"
        },
        ["UI.Error"] = new()
        {
            ["en"] = "[red]Error:[/] ",
            ["ru"] = "[red]Ошибка:[/] ",
            ["es"] = "[red]Error:[/] ",
            ["de"] = "[red]Fehler:[/] ",
            ["fr"] = "[red]Erreur:[/] ",
            ["pl"] = "[red]Błąd:[/] ",
            ["pt"] = "[red]Erro:[/] ",
            ["it"] = "[red]Errore:[/] ",
            ["tr"] = "[red]Hata:[/] "
        },
        ["UI.Rule.Title"] = new()
        {
            ["en"] = "Enter/Space - recreate, Esc - exit",
            ["ru"] = "Enter/Space - пересоздать, Esc - выход",
            ["es"] = "Enter/Space - recrear, Esc - salir",
            ["de"] = "Enter/Space - neu erstellen, Esc - beenden",
            ["fr"] = "Enter/Space - recréer, Esc - quitter",
            ["pl"] = "Enter/Space - odtwórz, Esc - wyjdź",
            ["pt"] = "Enter/Space - recriar, Esc - sair",
            ["it"] = "Enter/Space - ricrea, Esc - esci",
            ["tr"] = "Enter/Space - yeniden oluştur, Esc - çık"
        },
        ["UI.Rule.SubTitle"] = new()
        {
            ["en"] = "terraria-random --help for configuration",
            ["ru"] = "terraria-random --help для настройки",
            ["es"] = "terraria-random --help para configuración",
            ["de"] = "terraria-random --help für Konfiguration",
            ["fr"] = "terraria-random --help pour configuration",
            ["pl"] = "terraria-random --help dla konfiguracji",
            ["pt"] = "terraria-random --help para configuração",
            ["it"] = "terraria-random --help per configurazione",
            ["tr"] = "terraria-random --help yapılandırma için"
        },
        ["UI.Help.Options"] = new()
        {
            ["en"] = "Options:",
            ["ru"] = "Параметры:",
            ["es"] = "Opciones:",
            ["de"] = "Optionen:",
            ["fr"] = "Options :",
            ["pl"] = "Opcje:",
            ["pt"] = "Opções:",
            ["it"] = "Opzioni:",
            ["tr"] = "Seçenekler:"
        },
        ["UI.Help.Options.Help"] = new()
        {
            ["en"] = "  [yellow]--help[/]                       [grey]Show this help[/]",
            ["ru"] = "  [yellow]--help[/]                       [grey]Показать эту справку[/]",
            ["es"] = "  [yellow]--help[/]                       [grey]Mostrar esta ayuda[/]",
            ["de"] = "  [yellow]--help[/]                       [grey]Diese Hilfe anzeigen[/]",
            ["fr"] = "  [yellow]--help[/]                       [grey]Afficher cette aide[/]",
            ["pl"] = "  [yellow]--help[/]                       [grey]Pokaż tę pomoc[/]",
            ["pt"] = "  [yellow]--help[/]                       [grey]Mostrar esta ajuda[/]",
            ["it"] = "  [yellow]--help[/]                       [grey]Mostra questa guida[/]",
            ["tr"] = "  [yellow]--help[/]                       [grey]Bu yardımı göster[/]"
        },
        ["UI.Help.Options.Settings"] = new()
        {
            ["en"] = "  [yellow]--settings[/]                   [grey]Show UI settings[/]",
            ["ru"] = "  [yellow]--settings[/]                   [grey]Показать настройки UI[/]",
            ["es"] = "  [yellow]--settings[/]                   [grey]Mostrar ajustes de UI[/]",
            ["de"] = "  [yellow]--settings[/]                   [grey]UI-Einstellungen anzeigen[/]",
            ["fr"] = "  [yellow]--settings[/]                   [grey]Afficher les paramètres UI[/]",
            ["pl"] = "  [yellow]--settings[/]                   [grey]Pokaż ustawienia UI[/]",
            ["pt"] = "  [yellow]--settings[/]                   [grey]Mostrar configurações UI[/]",
            ["it"] = "  [yellow]--settings[/]                   [grey]Mostra impostazioni UI[/]",
            ["tr"] = "  [yellow]--settings[/]                   [grey]UI ayarlarını göster[/]"
        },
        ["UI.Help.Options.Count"] = new()
        {
            ["en"] = "  [yellow]--count=N[/]                    [grey]Number of characters to generate (default: 1, max: 12)[/]",
            ["ru"] = "  [yellow]--count=N[/]                    [grey]Количество персонажей для генерации (по умолчанию: 1, макс: 12)[/]",
            ["es"] = "  [yellow]--count=N[/]                    [grey]Número de personajes a generar (predeterminado: 1, máx: 12)[/]",
            ["de"] = "  [yellow]--count=N[/]                    [grey]Anzahl zu generierender Charaktere (Standard: 1, Max: 12)[/]",
            ["fr"] = "  [yellow]--count=N[/]                    [grey]Nombre de personnages à générer (défaut: 1, max: 12)[/]",
            ["pl"] = "  [yellow]--count=N[/]                    [grey]Liczba postaci do wygenerowania (domyślnie: 1, maks: 12)[/]",
            ["pt"] = "  [yellow]--count=N[/]                    [grey]Número de personagens para gerar (padrão: 1, máx: 12)[/]",
            ["it"] = "  [yellow]--count=N[/]                    [grey]Numero di personaggi da generare (predefinito: 1, max: 12)[/]",
            ["tr"] = "  [yellow]--count=N[/]                    [grey]Oluşturulacak karakter sayısı (varsayılan: 1, maks: 12)[/]"
        },
        ["UI.Help.Options.MaxAnimationFrames"] = new()
        {
            ["en"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Max animation frames (default: 150, min: 55)[/]",
            ["ru"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Макс. кадров анимации (по умолчанию: 150, мин: 55)[/]",
            ["es"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Máx. fotogramas de animación (predeterminado: 150, mín: 55)[/]",
            ["de"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Max. Animationsframes (Standard: 150, Min: 55)[/]",
            ["fr"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Max cadres d'animation (défaut: 150, min: 55)[/]",
            ["pl"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Maks. klatki animacji (domyślnie: 150, min: 55)[/]",
            ["pt"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Máx. frames de animação (padrão: 150, mín: 55)[/]",
            ["it"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Max frame animazione (predefinito: 150, min: 55)[/]",
            ["tr"] = "  [yellow]--maxAnimationFrames=N[/]       [grey]Maks. animasyon karesi (varsayılan: 150, min: 55)[/]"
        },
        ["UI.Help.Options.Fast"] = new()
        {
            ["en"] = "  [yellow]--fast[/]                       [grey]Disable roll animation[/]",
            ["ru"] = "  [yellow]--fast[/]                       [grey]Отключить анимацию ролла[/]",
            ["es"] = "  [yellow]--fast[/]                       [grey]Desactivar animación de rollo[/]",
            ["de"] = "  [yellow]--fast[/]                       [grey]Roll-Animation deaktivieren[/]",
            ["fr"] = "  [yellow]--fast[/]                       [grey]Désactiver animation de roulis[/]",
            ["pl"] = "  [yellow]--fast[/]                       [grey]Wyłącz animację rzutu[/]",
            ["pt"] = "  [yellow]--fast[/]                       [grey]Desativar animação de rolagem[/]",
            ["it"] = "  [yellow]--fast[/]                       [grey]Disabilita animazione roll[/]",
            ["tr"] = "  [yellow]--fast[/]                       [grey]Roll animasyonunu devre dışı bırak[/]"
        },
        ["UI.Help.Options.OnlyVanilla"] = new()
        {
            ["en"] = "  [yellow]--onlyVanilla[/]                [grey]Only Vanilla mode[/]",
            ["ru"] = "  [yellow]--onlyVanilla[/]                [grey]Только режим Vanilla[/]",
            ["es"] = "  [yellow]--onlyVanilla[/]                [grey]Solo modo Vanilla[/]",
            ["de"] = "  [yellow]--onlyVanilla[/]                [grey]Nur Vanilla-Modus[/]",
            ["fr"] = "  [yellow]--onlyVanilla[/]                [grey]Mode Vanilla uniquement[/]",
            ["pl"] = "  [yellow]--onlyVanilla[/]                [grey]Tylko tryb Vanilla[/]",
            ["pt"] = "  [yellow]--onlyVanilla[/]                [grey]Apenas modo Vanilla[/]",
            ["it"] = "  [yellow]--onlyVanilla[/]                [grey]Solo modalità Vanilla[/]",
            ["tr"] = "  [yellow]--onlyVanilla[/]                [grey]Sadece Vanilla modu[/]"
        },
        ["UI.Help.Options.OnlyCalamity"] = new()
        {
            ["en"] = "  [yellow]--onlyCalamity[/]               [grey]Only Calamity mode[/]",
            ["ru"] = "  [yellow]--onlyCalamity[/]               [grey]Только режим Calamity[/]",
            ["es"] = "  [yellow]--onlyCalamity[/]               [grey]Solo modo Calamity[/]",
            ["de"] = "  [yellow]--onlyCalamity[/]               [grey]Nur Calamity-Modus[/]",
            ["fr"] = "  [yellow]--onlyCalamity[/]               [grey]Mode Calamity uniquement[/]",
            ["pl"] = "  [yellow]--onlyCalamity[/]               [grey]Tylko tryb Calamity[/]",
            ["pt"] = "  [yellow]--onlyCalamity[/]               [grey]Apenas modo Calamity[/]",
            ["it"] = "  [yellow]--onlyCalamity[/]               [grey]Solo modalità Calamity[/]",
            ["tr"] = "  [yellow]--onlyCalamity[/]               [grey]Sadece Calamity modu[/]"
        },
        ["UI.Help.Options.UseSeeds"] = new()
        {
            ["en"] = "  [yellow]--useSeeds[/]                   [grey]Use special seeds[/]",
            ["ru"] = "  [yellow]--useSeeds[/]                   [grey]Использовать специальные сиды[/]",
            ["es"] = "  [yellow]--useSeeds[/]                   [grey]Usar semillas especiales[/]",
            ["de"] = "  [yellow]--useSeeds[/]                   [grey]Spezielle Seeds verwenden[/]",
            ["fr"] = "  [yellow]--useSeeds[/]                   [grey]Utiliser des graines spéciales[/]",
            ["pl"] = "  [yellow]--useSeeds[/]                   [grey]Używać specjalnych seedów[/]",
            ["pt"] = "  [yellow]--useSeeds[/]                   [grey]Usar sementes especiais[/]",
            ["it"] = "  [yellow]--useSeeds[/]                   [grey]Usa seed speciali[/]",
            ["tr"] = "  [yellow]--useSeeds[/]                   [grey]Özel seed'leri kullan[/]"
        },
        ["UI.Help.Options.UseChallenges"] = new()
        {
            ["en"] = "  [yellow]--useChallenges[/]              [grey]Use challenges[/]",
            ["ru"] = "  [yellow]--useChallenges[/]              [grey]Использовать испытания[/]",
            ["es"] = "  [yellow]--useChallenges[/]              [grey]Usar desafíos[/]",
            ["de"] = "  [yellow]--useChallenges[/]              [grey]Herausforderungen verwenden[/]",
            ["fr"] = "  [yellow]--useChallenges[/]              [grey]Utiliser les défis[/]",
            ["pl"] = "  [yellow]--useChallenges[/]              [grey]Używać wyzwań[/]",
            ["pt"] = "  [yellow]--useChallenges[/]              [grey]Usar desafios[/]",
            ["it"] = "  [yellow]--useChallenges[/]              [grey]Usa sfide[/]",
            ["tr"] = "  [yellow]--useChallenges[/]              [grey]Zorlukları kullan[/]"
        },
        ["UI.Help.Options.UseWorldSize"] = new()
        {
            ["en"] = "  [yellow]--useWorldSize[/]               [grey]Use world size[/]",
            ["ru"] = "  [yellow]--useWorldSize[/]               [grey]Использовать размер мира[/]",
            ["es"] = "  [yellow]--useWorldSize[/]               [grey]Usar tamaño del mundo[/]",
            ["de"] = "  [yellow]--useWorldSize[/]               [grey]Weltgröße verwenden[/]",
            ["fr"] = "  [yellow]--useWorldSize[/]               [grey]Utiliser la taille du monde[/]",
            ["pl"] = "  [yellow]--useWorldSize[/]               [grey]Używać rozmiaru świata[/]",
            ["pt"] = "  [yellow]--useWorldSize[/]               [grey]Usar tamanho do mundo[/]",
            ["it"] = "  [yellow]--useWorldSize[/]               [grey]Usa dimensione mondo[/]",
            ["tr"] = "  [yellow]--useWorldSize[/]               [grey]Dünya boyutunu kullan[/]"
        },
        ["UI.Help.Options.UseDifficulty"] = new()
        {
            ["en"] = "  [yellow]--useDifficulty[/]              [grey]Use difficulty[/]",
            ["ru"] = "  [yellow]--useDifficulty[/]              [grey]Использовать сложность[/]",
            ["es"] = "  [yellow]--useDifficulty[/]              [grey]Usar dificultad[/]",
            ["de"] = "  [yellow]--useDifficulty[/]              [grey]Schwierigkeitsgrad verwenden[/]",
            ["fr"] = "  [yellow]--useDifficulty[/]              [grey]Utiliser la difficulté[/]",
            ["pl"] = "  [yellow]--useDifficulty[/]              [grey]Używać trudności[/]",
            ["pt"] = "  [yellow]--useDifficulty[/]              [grey]Usar dificuldade[/]",
            ["it"] = "  [yellow]--useDifficulty[/]              [grey]Usa difficoltà[/]",
            ["tr"] = "  [yellow]--useDifficulty[/]              [grey]Zorluk kullan[/]"
        },
        ["UI.Help.Options.NoAscii"] = new()
        {
            ["en"] = "  [yellow]--noAscii[/]                    [grey]Disable ASCII art[/]",
            ["ru"] = "  [yellow]--noAscii[/]                    [grey]Отключить ASCII-арт[/]",
            ["es"] = "  [yellow]--noAscii[/]                    [grey]Desactivar arte ASCII[/]",
            ["de"] = "  [yellow]--noAscii[/]                    [grey]ASCII-Art deaktivieren[/]",
            ["fr"] = "  [yellow]--noAscii[/]                    [grey]Désactiver l'art ASCII[/]",
            ["pl"] = "  [yellow]--noAscii[/]                    [grey]Wyłącz ASCII art[/]",
            ["pt"] = "  [yellow]--noAscii[/]                    [grey]Desativar arte ASCII[/]",
            ["it"] = "  [yellow]--noAscii[/]                    [grey]Disabilita arte ASCII[/]",
            ["tr"] = "  [yellow]--noAscii[/]                    [grey]ASCII sanatını devre dışı bırak[/]"
        },
        ["UI.Help.Options.NoColor"] = new()
        {
            ["en"] = "  [yellow]--noColor[/]                    [grey]Disable colors[/]",
            ["ru"] = "  [yellow]--noColor[/]                    [grey]Отключить цвета[/]",
            ["es"] = "  [yellow]--noColor[/]                    [grey]Desactivar colores[/]",
            ["de"] = "  [yellow]--noColor[/]                    [grey]Farben deaktivieren[/]",
            ["fr"] = "  [yellow]--noColor[/]                    [grey]Désactiver les couleurs[/]",
            ["pl"] = "  [yellow]--noColor[/]                    [grey]Wyłącz kolory[/]",
            ["pt"] = "  [yellow]--noColor[/]                    [grey]Desativar cores[/]",
            ["it"] = "  [yellow]--noColor[/]                    [grey]Disabilita colori[/]",
            ["tr"] = "  [yellow]--noColor[/]                    [grey]Renkleri devre dışı bırak[/]"
        },
        ["UI.Help.Options.DisableClasses"] = new()
        {
            ["en"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Disable specific classes[/]",
            ["ru"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Отключить определённые классы[/]",
            ["es"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Desactivar clases específicas[/]",
            ["de"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Spezifische Klassen deaktivieren[/]",
            ["fr"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Désactiver classes spécifiques[/]",
            ["pl"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Wyłącz konkretne klasy[/]",
            ["pt"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Desativar classes específicas[/]",
            ["it"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Disabilita classi specifiche[/]",
            ["tr"] = "  [yellow]--disableClasses=CLASS,...[/]   [grey]Belirli sınıfları devre dışı bırak[/]"
        },
        ["UI.Help.Options.EnableClasses"] = new()
        {
            ["en"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]Enable ONLY listed classes[/]",
            ["ru"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]Включить ТОЛЬКО указанные классы[/]",
            ["es"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]Activar SOLO clases listadas[/]",
            ["de"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]NUR aufgeführte Klassen aktivieren[/]",
            ["fr"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]Activer SEULEMENT classes listées[/]",
            ["pl"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]Włącz TYLKO wymienione klasy[/]",
            ["pt"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]Ativar APENAS classes listadas[/]",
            ["it"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]Attiva SOLO classi elencate[/]",
            ["tr"] = "  [yellow]--enableClasses=CLASS,...[/]    [grey]SADECE listelenen sınıfları etkinleştir[/]"
        },
        ["UI.Help.Options.ListClasses"] = new()
        {
            ["en"] = "  [yellow]--listClasses[/]                [grey]List available classes[/]",
            ["ru"] = "  [yellow]--listClasses[/]                [grey]Список доступных классов[/]",
            ["es"] = "  [yellow]--listClasses[/]                [grey]Listar clases disponibles[/]",
            ["de"] = "  [yellow]--listClasses[/]                [grey]Verfügbare Klassen auflisten[/]",
            ["fr"] = "  [yellow]--listClasses[/]                [grey]Lister les classes disponibles[/]",
            ["pl"] = "  [yellow]--listClasses[/]                [grey]Lista dostępnych klas[/]",
            ["pt"] = "  [yellow]--listClasses[/]                [grey]Listar classes disponíveis[/]",
            ["it"] = "  [yellow]--listClasses[/]                [grey]Elenca classi disponibili[/]",
            ["tr"] = "  [yellow]--listClasses[/]                [grey]Mevcut sınıfları listele[/]"
        },
        ["UI.Help.Options.Language"] = new()
        {
            ["en"] = "  [yellow]--language[/]                   [grey]Use selected language (default: en)[/]",
            ["ru"] = "  [yellow]--language[/]                   [grey]Использовать выбранный язык (по умолчанию: en)[/]",
            ["es"] = "  [yellow]--language[/]                   [grey]Usar idioma seleccionado (predeterminado: en)[/]",
            ["de"] = "  [yellow]--language[/]                   [grey]Gewählte Sprache verwenden (Standard: en)[/]",
            ["fr"] = "  [yellow]--language[/]                   [grey]Utiliser la langue sélectionnée (défaut: en)[/]",
            ["pl"] = "  [yellow]--language[/]                   [grey]Użyj wybranego języka (domyślnie: en)[/]",
            ["pt"] = "  [yellow]--language[/]                   [grey]Usar idioma selecionado (padrão: en)[/]",
            ["it"] = "  [yellow]--language[/]                   [grey]Usa lingua selezionata (predefinito: en)[/]",
            ["tr"] = "  [yellow]--language[/]                   [grey]Seçili dili kullan (varsayılan: en)[/]"
        },
        ["UI.Help.Options.Languages"] = new()
        {
            ["en"] = "  [yellow]--listLanguages[/]              [grey]List available languages[/]",
            ["ru"] = "  [yellow]--listLanguages[/]              [grey]Список доступных языков[/]",
            ["es"] = "  [yellow]--listLanguages[/]              [grey]Listar idiomas disponibles[/]",
            ["de"] = "  [yellow]--listLanguages[/]              [grey]Verfügbare Sprachen auflisten[/]",
            ["fr"] = "  [yellow]--listLanguages[/]              [grey]Lister les langues disponibles[/]",
            ["pl"] = "  [yellow]--listLanguages[/]              [grey]Lista dostępnych języków[/]",
            ["pt"] = "  [yellow]--listLanguages[/]              [grey]Listar idiomas disponíveis[/]",
            ["it"] = "  [yellow]--listLanguages[/]              [grey]Elenca lingue disponibili[/]",
            ["tr"] = "  [yellow]--listLanguages[/]              [grey]Mevcut dilleri listele[/]"
        },
        ["UI.Help.Examples"] = new()
        {
            ["en"] = "[grey]Examples:[/]",
            ["ru"] = "[grey]Примеры:[/]",
            ["es"] = "[grey]Ejemplos:[/]",
            ["de"] = "[grey]Beispiele:[/]",
            ["fr"] = "[grey]Exemples:[/]",
            ["pl"] = "[grey]Przykłady:[/]",
            ["pt"] = "[grey]Exemplos:[/]",
            ["it"] = "[grey]Esempi:[/]",
            ["tr"] = "[grey]Örnekler:[/]"
        },
        ["UI.Help.Examples.Example1"] = new()
        {
            ["en"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]",
            ["ru"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]",
            ["es"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]",
            ["de"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]",
            ["fr"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]",
            ["pl"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]",
            ["pt"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]",
            ["it"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]",
            ["tr"] = "  [green]terraria-randomizer[/] [yellow]--count=3 --fast --noAscii --noColor[/]"
        },
        ["UI.Help.Examples.Example2"] = new()
        {
            ["en"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]",
            ["ru"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]",
            ["es"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]",
            ["de"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]",
            ["fr"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]",
            ["pl"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]",
            ["pt"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]",
            ["it"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]",
            ["tr"] = "  [green]terraria-randomizer[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]"
        },
        ["UI.Classes"] = new()
        {
            ["en"] = "[grey]Available classes:[/]",
            ["ru"] = "[grey]Доступные классы:[/]",
            ["es"] = "[grey]Clases disponibles:[/]",
            ["de"] = "[grey]Verfügbare Klassen:[/]",
            ["fr"] = "[grey]Classes disponibles:[/]",
            ["pl"] = "[grey]Dostępne klasy:[/]",
            ["pt"] = "[grey]Classes disponíveis:[/]",
            ["it"] = "[grey]Classi disponibili:[/]",
            ["tr"] = "[grey]Mevcut sınıflar:[/]"
        },
        ["UI.Language"] = new()
        {
            ["en"] = "[grey]Available languages:[/]",
            ["ru"] = "[grey]Доступные языки:[/]",
            ["es"] = "[grey]Idiomas disponibles:[/]",
            ["de"] = "[grey]Verfügbare Sprachen:[/]",
            ["fr"] = "[grey]Langues disponibles:[/]",
            ["pl"] = "[grey]Dostępne języki:[/]",
            ["pt"] = "[grey]Idiomas disponíveis:[/]",
            ["it"] = "[grey]Lingue disponibili:[/]",
            ["tr"] = "[grey]Mevcut diller:[/]"
        },
        ["UI.Results.GameVersion"] = new()
        {
            ["en"] = "Game Version",
            ["ru"] = "Версия игры",
            ["es"] = "Versión del Juego",
            ["de"] = "Spielversion",
            ["fr"] = "Version du Jeu",
            ["pl"] = "Wersja Gry",
            ["pt"] = "Versão do Jogo",
            ["it"] = "Versione del Gioco",
            ["tr"] = "Oyun Sürümü"
        },
        ["UI.Results.Name"] = new()
        {
            ["en"] = "Name",
            ["ru"] = "Имя",
            ["es"] = "Nombre",
            ["de"] = "Name",
            ["fr"] = "Nom",
            ["pl"] = "Nazwa",
            ["pt"] = "Nome",
            ["it"] = "Nome",
            ["tr"] = "İsim"
        },
        ["UI.Results.WorldName"] = new()
        {
            ["en"] = "World Name",
            ["ru"] = "Имя мира",
            ["es"] = "Nombre del Mundo",
            ["de"] = "Weltname",
            ["fr"] = "Nom du Monde",
            ["pl"] = "Nazwa Świata",
            ["pt"] = "Nome do Mundo",
            ["it"] = "Nome del Mondo",
            ["tr"] = "Dünya Adı"
        },
        ["UI.Results.Class"] = new()
        {
            ["en"] = "Class",
            ["ru"] = "Класс",
            ["es"] = "Clase",
            ["de"] = "Klasse",
            ["fr"] = "Classe",
            ["pl"] = "Klasa",
            ["pt"] = "Classe",
            ["it"] = "Classe",
            ["tr"] = "Sınıf"
        },
        ["UI.Results.WorldEvil"] = new()
        {
            ["en"] = "World Evil",
            ["ru"] = "Зло мира",
            ["es"] = "Mal del Mundo",
            ["de"] = "Weltböse",
            ["fr"] = "Mal du Monde",
            ["pl"] = "Zło Świata",
            ["pt"] = "Mal do Mundo",
            ["it"] = "Male del Mondo",
            ["tr"] = "Dünya Kötülüğü"
        },
        ["UI.Results.Challenge"] = new()
        {
            ["en"] = "Challenge",
            ["ru"] = "Испытание",
            ["es"] = "Desafío",
            ["de"] = "Herausforderung",
            ["fr"] = "Défi",
            ["pl"] = "Wyzwanie",
            ["pt"] = "Desafio",
            ["it"] = "Sfida",
            ["tr"] = "Zorluk"
        },
        ["UI.Results.Seed"] = new()
        {
            ["en"] = "Seed",
            ["ru"] = "Сид",
            ["es"] = "Semilla",
            ["de"] = "Seed",
            ["fr"] = "Graine",
            ["pl"] = "Seed",
            ["pt"] = "Semente",
            ["it"] = "Seed",
            ["tr"] = "Seed"
        },
        ["UI.Results.MapSize"] = new()
        {
            ["en"] = "Map Size",
            ["ru"] = "Размер карты",
            ["es"] = "Tamaño del Mapa",
            ["de"] = "Kartengröße",
            ["fr"] = "Taille de la Carte",
            ["pl"] = "Rozmiar Mapy",
            ["pt"] = "Tamanho do Mapa",
            ["it"] = "Dimensione Mappa",
            ["tr"] = "Harita Boyutu"
        },
        ["UI.Results.Difficulty"] = new()
        {
            ["en"] = "Difficulty",
            ["ru"] = "Сложность",
            ["es"] = "Dificultad",
            ["de"] = "Schwierigkeit",
            ["fr"] = "Difficulté",
            ["pl"] = "Trudność",
            ["pt"] = "Dificuldade",
            ["it"] = "Difficoltà",
            ["tr"] = "Zorluk"
        },
        ["GenerateCharacter.ValidClasses.Error"] = new()
        {
            ["en"] = "No character classes available!",
            ["ru"] = "Нет доступных классов персонажей!",
            ["es"] = "¡No hay clases de personajes disponibles!",
            ["de"] = "Keine Charakterklassen verfügbar!",
            ["fr"] = "Aucune classe de personnage disponible !",
            ["pl"] = "Brak dostępnych klas postaci!",
            ["pt"] = "Nenhuma classe de personagem disponível!",
            ["it"] = "Nessuna classe personaggio disponibile!",
            ["tr"] = "Karakter sınıfı yok!"
        },
    };

    public static string Localize(this string tag, string language) => Localizations[tag][language];

    public static List<string> GetLanguages() => Localizations.First().Value.Keys.ToList();

    public static List<string> GetLanguagesWithName() => GetLanguages().Select(code => $"{code} - {LangNames.GetValueOrDefault(code, code.ToUpper())}").ToList();

    public static string GetCode(string input)
    {
        var code = input.Trim().ToLower();
        if (GetLanguages().Contains(code)) return code;
        return NameToCode.TryGetValue(code, out var result) ? result : null;
    }
}
