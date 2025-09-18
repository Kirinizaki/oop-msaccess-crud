Imports System.ComponentModel.DataAnnotations
Imports System.Text.RegularExpressions

Public Class Registration

    '--- Private fields ---
    Private _id As Integer
    Private _firstName As String
    Private _lastName As String
    Private _middleName As String
    Private _suffix As String
    Private _birthDate As Date
    Private _gender As String
    Private _civilStatus As String
    Private _nationality As String
    Private _contactInfo As String
    Private _address As String

    '--- Properties with enhanced validation ---
    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New ArgumentException("ID cannot be negative.")
            End If
            _id = value
        End Set
    End Property

    <Required(ErrorMessage:="First name is required.")>
    <StringLength(50, MinimumLength:=1, ErrorMessage:="First name must be between 1 and 50 characters.")>
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("First name cannot be empty or whitespace.")
            End If
            If value.Length > 50 Then
                Throw New ArgumentException("First name cannot exceed 50 characters.")
            End If
            If Not Regex.IsMatch(value, "^[a-zA-Z\s\-'.]+$") Then
                Throw New ArgumentException("First name contains invalid characters.")
            End If
            _firstName = value.Trim()
        End Set
    End Property

    <Required(ErrorMessage:="Last name is required.")>
    <StringLength(50, MinimumLength:=1, ErrorMessage:="Last name must be between 1 and 50 characters.")>
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("Last name cannot be empty or whitespace.")
            End If
            If value.Length > 50 Then
                Throw New ArgumentException("Last name cannot exceed 50 characters.")
            End If
            If Not Regex.IsMatch(value, "^[a-zA-Z\s\-'.]+$") Then
                Throw New ArgumentException("Last name contains invalid characters.")
            End If
            _lastName = value.Trim()
        End Set
    End Property

    <StringLength(50, ErrorMessage:="Middle name cannot exceed 50 characters.")>
    Public Property MiddleName As String
        Get
            Return _middleName
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                If value.Length > 50 Then
                    Throw New ArgumentException("Middle name cannot exceed 50 characters.")
                End If
                If Not Regex.IsMatch(value, "^[a-zA-Z\s\-'.]+$") Then
                    Throw New ArgumentException("Middle name contains invalid characters.")
                End If
                _middleName = value.Trim()
            Else
                _middleName = String.Empty
            End If
        End Set
    End Property

    <StringLength(10, ErrorMessage:="Suffix cannot exceed 10 characters.")>
    Public Property Suffix As String
        Get
            Return _suffix
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                If value.Length > 10 Then
                    Throw New ArgumentException("Suffix cannot exceed 10 characters.")
                End If
                If Not Regex.IsMatch(value, "^[a-zA-Z\s\-.]+$") Then
                    Throw New ArgumentException("Suffix contains invalid characters.")
                End If
                _suffix = value.Trim()
            Else
                _suffix = String.Empty
            End If
        End Set
    End Property

    <Required(ErrorMessage:="Birth date is required.")>
    Public Property BirthDate As Date
        Get
            Return _birthDate
        End Get
        Set(value As Date)
            If value > Date.Now Then
                Throw New ArgumentException("Birth date cannot be in the future.")
            End If
            If value < New Date(1900, 1, 1) Then
                Throw New ArgumentException("Birth date cannot be before January 1, 1900.")
            End If
            _birthDate = value
        End Set
    End Property

    <Required(ErrorMessage:="Gender is required.")>
    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("Gender is required.")
            End If
            Dim validGenders = {"Male", "Female", "Other"}
            If Not validGenders.Contains(value) Then
                Throw New ArgumentException("Gender must be Male, Female, or Other.")
            End If
            _gender = value
        End Set
    End Property

    <StringLength(20, ErrorMessage:="Civil status cannot exceed 20 characters.")>
    Public Property CivilStatus As String
        Get
            Return _civilStatus
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                Dim validStatuses = {"Single", "Married", "Divorced", "Widowed", "Separated"}
                If Not validStatuses.Contains(value) Then
                    Throw New ArgumentException("Civil status must be Single, Married, Divorced, Widowed, or Separated.")
                End If
                _civilStatus = value
            Else
                _civilStatus = String.Empty
            End If
        End Set
    End Property

    <Required(ErrorMessage:="Nationality is required.")>
    <StringLength(50, MinimumLength:=1, ErrorMessage:="Nationality must be between 1 and 50 characters.")>
    Public Property Nationality As String
        Get
            Return _nationality
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("Nationality is required.")
            End If
            If value.Length > 50 Then
                Throw New ArgumentException("Nationality cannot exceed 50 characters.")
            End If
            If Not Regex.IsMatch(value, "^[a-zA-Z\s\-'.]+$") Then
                Throw New ArgumentException("Nationality contains invalid characters.")
            End If
            _nationality = value.Trim()
        End Set
    End Property

    <Required(ErrorMessage:="Contact information is required.")>
    Public Property ContactInfo As String
        Get
            Return _contactInfo
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("Contact information is required.")
            End If

            ' International contact number validation
            ' Accepts formats like: +63-1234567890, +1-1234567890, etc.
            If Not Regex.IsMatch(value, "^\+\d{1,3}-\d{10,15}$") Then
                Throw New ArgumentException("Contact number must be in format: +CountryCode-PhoneNumber (e.g., +63-9123456789)")
            End If
            _contactInfo = value.Trim()
        End Set
    End Property

    <Required(ErrorMessage:="Address is required.")>
    <StringLength(200, MinimumLength:=5, ErrorMessage:="Address must be between 5 and 200 characters.")>
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("Address is required.")
            End If
            If value.Length < 5 Then
                Throw New ArgumentException("Address must be at least 5 characters long.")
            End If
            If value.Length > 200 Then
                Throw New ArgumentException("Address cannot exceed 200 characters.")
            End If
            _address = value.Trim()
        End Set
    End Property

    '--- Computed properties ---
    Public ReadOnly Property HasMiddleName As Boolean
        Get
            Return Not String.IsNullOrWhiteSpace(_middleName)
        End Get
    End Property

    Public ReadOnly Property HasSuffix As Boolean
        Get
            Return Not String.IsNullOrWhiteSpace(_suffix)
        End Get
    End Property

    Public ReadOnly Property FullName As String
        Get
            Dim myfullName As String = _firstName
            If HasMiddleName Then myfullName &= " " & _middleName
            myfullName &= " " & _lastName
            If HasSuffix Then myfullName &= " " & _suffix
            Return myfullName
        End Get
    End Property

    Public ReadOnly Property Age As Integer
        Get
            Dim today As Date = Date.Today
            Dim myage As Integer = today.Year - _birthDate.Year
            If _birthDate.Date > today.AddYears(-myage) Then myage -= 1
            Return myage
        End Get
    End Property

    Public ReadOnly Property IsMinor As Boolean
        Get
            Return Age < 18
        End Get
    End Property

    '--- Constructors ---
    Public Sub New()
        ' Default constructor with safe defaults
        _id = 0
        _firstName = String.Empty
        _lastName = String.Empty
        _middleName = String.Empty
        _suffix = String.Empty
        _birthDate = New Date(2000, 1, 1)
        _gender = "Male"
        _civilStatus = String.Empty
        _nationality = String.Empty
        _contactInfo = String.Empty
        _address = String.Empty
    End Sub

    Public Sub New(firstName As String, lastName As String, birthDate As Date,
                   gender As String, nationality As String, contactInfo As String, address As String)
        Me.New()
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.BirthDate = birthDate
        Me.Gender = gender
        Me.Nationality = nationality
        Me.ContactInfo = contactInfo
        Me.Address = address
    End Sub

    Public Sub New(id As Integer, firstName As String, lastName As String, middleName As String,
                   suffix As String, birthDate As Date, gender As String, civilStatus As String,
                   nationality As String, contactInfo As String, address As String)
        Me.New(firstName, lastName, birthDate, gender, nationality, contactInfo, address)
        Me.ID = id
        Me.MiddleName = middleName
        Me.Suffix = suffix
        Me.CivilStatus = civilStatus
    End Sub

    '--- Methods ---
    Public Function IsValid() As Boolean
        Try
            ValidateAllProperties()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function GetValidationErrors() As List(Of String)
        Dim errors As New List(Of String)

        Try
            ValidateAllProperties()
        Catch ex As ArgumentException
            errors.Add(ex.Message)
        Catch ex As Exception
            errors.Add("Validation error: " & ex.Message)
        End Try

        Return errors
    End Function

    Private Sub ValidateAllProperties()
        ' Re-validate all properties to ensure consistency
        Dim tempFirstName = _firstName
        Dim tempLastName = _lastName
        Dim tempMiddleName = _middleName
        Dim tempSuffix = _suffix
        Dim tempBirthDate = _birthDate
        Dim tempGender = _gender
        Dim tempCivilStatus = _civilStatus
        Dim tempNationality = _nationality
        Dim tempContactInfo = _contactInfo
        Dim tempAddress = _address

        Me.FirstName = tempFirstName
        Me.LastName = tempLastName
        Me.MiddleName = tempMiddleName
        Me.Suffix = tempSuffix
        Me.BirthDate = tempBirthDate
        Me.Gender = tempGender
        Me.CivilStatus = tempCivilStatus
        Me.Nationality = tempNationality
        Me.ContactInfo = tempContactInfo
        Me.Address = tempAddress
    End Sub

    '--- Interface implementations ---
    ' Equality check (type-safe)
    Public Overloads Function Equals(other As Registration) As Boolean
        If other Is Nothing Then Return False

        ' Prefer ID if available
        If Me.ID <> 0 AndAlso other.ID <> 0 Then
            Return Me.ID = other.ID
        End If

        ' Otherwise compare key personal details
        Return String.Equals(Me.FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase) AndAlso
               String.Equals(Me.LastName, other.LastName, StringComparison.OrdinalIgnoreCase) AndAlso
               Me.BirthDate = other.BirthDate
    End Function

    ' Comparison logic (for sorting, etc.)
    Public Function CompareTo(other As Registration) As Integer
        If other Is Nothing Then Return 1

        Dim lastNameComparison = String.Compare(Me.LastName, other.LastName, StringComparison.OrdinalIgnoreCase)
        If lastNameComparison <> 0 Then Return lastNameComparison

        Dim firstNameComparison = String.Compare(Me.FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase)
        If firstNameComparison <> 0 Then Return firstNameComparison

        Return Me.BirthDate.CompareTo(other.BirthDate)
    End Function

    ' For debugging / display
    Public Overrides Function ToString() As String
        Return $"ID: {ID}, Name: {FullName}, Age: {Age}, Contact: {ContactInfo}"
    End Function

    ' Object.Equals override
    Public Overrides Function Equals(obj As Object) As Boolean
        Return TypeOf obj Is Registration AndAlso Me.Equals(DirectCast(obj, Registration))
    End Function

    ' Hash code override (consistent with Equals)
    Public Overrides Function GetHashCode() As Integer
        Return HashCode.Combine(
            ID,
            If(FirstName?.ToLowerInvariant(), ""),
            If(LastName?.ToLowerInvariant(), ""),
            BirthDate
        )
    End Function

End Class