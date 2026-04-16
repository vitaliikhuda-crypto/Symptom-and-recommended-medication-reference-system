<Window
    x:Class="MedSearchWPF.Views.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:vm="clr-namespace:MedSearchWPF.ViewModels"
    Title="МедПошук — Симптоми та Ліки"
    Width="1100" Height="700"
    MinWidth="800" MinHeight="550"
    WindowStartupLocation="CenterScreen"
    Background="{DynamicResource BgBrush}">

    <Window.DataContext>
        <vm:MainViewModel/>
    </Window.DataContext>

    <!-- GRID: основна структура вікна -->
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="220"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>

        <!-- Бокова панель -->
        <Border Grid.Column="0" Background="#0F2744">
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="*"/>
                    <RowDefinition Height="Auto"/>
                </Grid.RowDefinitions>

                <!-- STACKPANEL: логотип -->
                <StackPanel Grid.Row="0" Margin="20,28,20,24">
                    <TextBlock Text="💊" FontSize="36" HorizontalAlignment="Center"/>
                    <TextBlock Text="МедПошук" FontSize="20" FontWeight="Bold"
                               Foreground="White" HorizontalAlignment="Center" Margin="0,6,0,2"/>
                    <TextBlock Text="Симптоми та ліки" FontSize="11"
                               Foreground="#7A9AC0" HorizontalAlignment="Center"/>
                </StackPanel>

                <!-- STACKPANEL: навігація -->
                <StackPanel Grid.Row="1" Margin="12,0">
                    <Button Style="{StaticResource NavButton}"
                            Command="{Binding NavigateCommand}"
                            CommandParameter="search"
                            x:Name="BtnSearch"
                            Content="🔍  Пошук ліків"/>
                    <Button Content="📋 Препарати"
                            Command="{Binding NavigateCommand}"
                            CommandParameter="medicines"/>
                    <Button Style="{StaticResource NavButton}"
                            Command="{Binding NavigateCommand}"
                            CommandParameter="list"
                            Content="📋  Всі симптоми"/>
                    <Button Style="{StaticResource NavButton}"
                            Command="{Binding NavigateCommand}"
                            CommandParameter="settings"
                            Content="⚙️  Налаштування"/>
                </StackPanel>

                <!-- STACKPANEL: тема + мова -->
                <StackPanel Grid.Row="2" Margin="12,0,12,20">
                    <Separator Background="#1E3A5F" Margin="0,0,0,10"/>
                    <Button Style="{StaticResource NavButton}"
                            Command="{Binding ToggleThemeCommand}"
                            Content="{Binding ThemeLabel}"/>
                    <Button Style="{StaticResource NavButton}"
                            Command="{Binding ToggleLangCommand}"
                            Content="{Binding LanguageLabel}"/>
                </StackPanel>
            </Grid>
        </Border>

        <!-- DOCKPANEL: статус-рядок зверху + Frame -->
        <DockPanel Grid.Column="1" LastChildFill="True">

            <Border DockPanel.Dock="Top"
                    Background="{DynamicResource SurfaceBrush}"
                    BorderBrush="#E2E8F0"
                    BorderThickness="0,0,0,1"
                    Padding="24,10">
                <Grid>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="Auto"/>
                    </Grid.ColumnDefinitions>
                    <TextBlock Grid.Column="0"
                               Text="{Binding StatusMessage}"
                               FontSize="13"
                               Foreground="{DynamicResource TextSecondaryBrush}"
                               VerticalAlignment="Center"/>
                    <TextBlock Grid.Column="1"
                               Text="МедПошук v1.0"
                               FontSize="12"
                               Foreground="#94A3B8"
                               VerticalAlignment="Center"/>
                </Grid>
            </Border>

            <Frame x:Name="MainFrame"
                   NavigationUIVisibility="Hidden"
                   Background="{DynamicResource BgBrush}"/>
        </DockPanel>
    </Grid>
</Window>
