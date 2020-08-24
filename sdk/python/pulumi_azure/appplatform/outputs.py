# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables
from . import outputs

__all__ = [
    'SpringCloudServiceConfigServerGitSetting',
    'SpringCloudServiceConfigServerGitSettingHttpBasicAuth',
    'SpringCloudServiceConfigServerGitSettingRepository',
    'SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth',
    'SpringCloudServiceConfigServerGitSettingRepositorySshAuth',
    'SpringCloudServiceConfigServerGitSettingSshAuth',
    'SpringCloudServiceTrace',
    'GetSpringCloudServiceConfigServerGitSettingResult',
    'GetSpringCloudServiceConfigServerGitSettingHttpBasicAuthResult',
    'GetSpringCloudServiceConfigServerGitSettingRepositoryResult',
    'GetSpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthResult',
    'GetSpringCloudServiceConfigServerGitSettingRepositorySshAuthResult',
    'GetSpringCloudServiceConfigServerGitSettingSshAuthResult',
]

@pulumi.output_type
class SpringCloudServiceConfigServerGitSetting(dict):
    def __init__(__self__, *,
                 uri: str,
                 http_basic_auth: Optional['outputs.SpringCloudServiceConfigServerGitSettingHttpBasicAuth'] = None,
                 label: Optional[str] = None,
                 repositories: Optional[List['outputs.SpringCloudServiceConfigServerGitSettingRepository']] = None,
                 search_paths: Optional[List[str]] = None,
                 ssh_auth: Optional['outputs.SpringCloudServiceConfigServerGitSettingSshAuth'] = None):
        """
        :param str uri: The URI of the default Git repository used as the Config Server back end, should be started with `http://`, `https://`, `git@`, or `ssh://`.
        :param 'SpringCloudServiceConfigServerGitSettingHttpBasicAuthArgs' http_basic_auth: A `http_basic_auth` block as defined below.
        :param str label: The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        :param List['SpringCloudServiceConfigServerGitSettingRepositoryArgs'] repositories: One or more `repository` blocks as defined below.
        :param List[str] search_paths: An array of strings used to search subdirectories of the Git repository.
        :param 'SpringCloudServiceConfigServerGitSettingSshAuthArgs' ssh_auth: A `ssh_auth` block as defined below.
        """
        pulumi.set(__self__, "uri", uri)
        if http_basic_auth is not None:
            pulumi.set(__self__, "http_basic_auth", http_basic_auth)
        if label is not None:
            pulumi.set(__self__, "label", label)
        if repositories is not None:
            pulumi.set(__self__, "repositories", repositories)
        if search_paths is not None:
            pulumi.set(__self__, "search_paths", search_paths)
        if ssh_auth is not None:
            pulumi.set(__self__, "ssh_auth", ssh_auth)

    @property
    @pulumi.getter
    def uri(self) -> str:
        """
        The URI of the default Git repository used as the Config Server back end, should be started with `http://`, `https://`, `git@`, or `ssh://`.
        """
        return pulumi.get(self, "uri")

    @property
    @pulumi.getter(name="httpBasicAuth")
    def http_basic_auth(self) -> Optional['outputs.SpringCloudServiceConfigServerGitSettingHttpBasicAuth']:
        """
        A `http_basic_auth` block as defined below.
        """
        return pulumi.get(self, "http_basic_auth")

    @property
    @pulumi.getter
    def label(self) -> Optional[str]:
        """
        The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        """
        return pulumi.get(self, "label")

    @property
    @pulumi.getter
    def repositories(self) -> Optional[List['outputs.SpringCloudServiceConfigServerGitSettingRepository']]:
        """
        One or more `repository` blocks as defined below.
        """
        return pulumi.get(self, "repositories")

    @property
    @pulumi.getter(name="searchPaths")
    def search_paths(self) -> Optional[List[str]]:
        """
        An array of strings used to search subdirectories of the Git repository.
        """
        return pulumi.get(self, "search_paths")

    @property
    @pulumi.getter(name="sshAuth")
    def ssh_auth(self) -> Optional['outputs.SpringCloudServiceConfigServerGitSettingSshAuth']:
        """
        A `ssh_auth` block as defined below.
        """
        return pulumi.get(self, "ssh_auth")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SpringCloudServiceConfigServerGitSettingHttpBasicAuth(dict):
    def __init__(__self__, *,
                 password: str,
                 username: str):
        """
        :param str password: The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        :param str username: The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        """
        pulumi.set(__self__, "password", password)
        pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> str:
        """
        The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def username(self) -> str:
        """
        The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        """
        return pulumi.get(self, "username")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SpringCloudServiceConfigServerGitSettingRepository(dict):
    def __init__(__self__, *,
                 name: str,
                 uri: str,
                 http_basic_auth: Optional['outputs.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth'] = None,
                 label: Optional[str] = None,
                 patterns: Optional[List[str]] = None,
                 search_paths: Optional[List[str]] = None,
                 ssh_auth: Optional['outputs.SpringCloudServiceConfigServerGitSettingRepositorySshAuth'] = None):
        """
        :param str name: A name to identify on the Git repository, required only if repos exists.
        :param str uri: The URI of the Git repository that's used as the Config Server back end should be started with `http://`, `https://`, `git@`, or `ssh://`.
        :param 'SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthArgs' http_basic_auth: A `http_basic_auth` block as defined below.
        :param str label: The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        :param List[str] patterns: An array of strings used to match an application name. For each pattern, use the `{application}/{profile}` format with wildcards.
        :param List[str] search_paths: An array of strings used to search subdirectories of the Git repository.
        :param 'SpringCloudServiceConfigServerGitSettingRepositorySshAuthArgs' ssh_auth: A `ssh_auth` block as defined below.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "uri", uri)
        if http_basic_auth is not None:
            pulumi.set(__self__, "http_basic_auth", http_basic_auth)
        if label is not None:
            pulumi.set(__self__, "label", label)
        if patterns is not None:
            pulumi.set(__self__, "patterns", patterns)
        if search_paths is not None:
            pulumi.set(__self__, "search_paths", search_paths)
        if ssh_auth is not None:
            pulumi.set(__self__, "ssh_auth", ssh_auth)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        A name to identify on the Git repository, required only if repos exists.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def uri(self) -> str:
        """
        The URI of the Git repository that's used as the Config Server back end should be started with `http://`, `https://`, `git@`, or `ssh://`.
        """
        return pulumi.get(self, "uri")

    @property
    @pulumi.getter(name="httpBasicAuth")
    def http_basic_auth(self) -> Optional['outputs.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth']:
        """
        A `http_basic_auth` block as defined below.
        """
        return pulumi.get(self, "http_basic_auth")

    @property
    @pulumi.getter
    def label(self) -> Optional[str]:
        """
        The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        """
        return pulumi.get(self, "label")

    @property
    @pulumi.getter
    def patterns(self) -> Optional[List[str]]:
        """
        An array of strings used to match an application name. For each pattern, use the `{application}/{profile}` format with wildcards.
        """
        return pulumi.get(self, "patterns")

    @property
    @pulumi.getter(name="searchPaths")
    def search_paths(self) -> Optional[List[str]]:
        """
        An array of strings used to search subdirectories of the Git repository.
        """
        return pulumi.get(self, "search_paths")

    @property
    @pulumi.getter(name="sshAuth")
    def ssh_auth(self) -> Optional['outputs.SpringCloudServiceConfigServerGitSettingRepositorySshAuth']:
        """
        A `ssh_auth` block as defined below.
        """
        return pulumi.get(self, "ssh_auth")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth(dict):
    def __init__(__self__, *,
                 password: str,
                 username: str):
        """
        :param str password: The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        :param str username: The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        """
        pulumi.set(__self__, "password", password)
        pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> str:
        """
        The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def username(self) -> str:
        """
        The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        """
        return pulumi.get(self, "username")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SpringCloudServiceConfigServerGitSettingRepositorySshAuth(dict):
    def __init__(__self__, *,
                 private_key: str,
                 host_key: Optional[str] = None,
                 host_key_algorithm: Optional[str] = None,
                 strict_host_key_checking_enabled: Optional[bool] = None):
        """
        :param str private_key: The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        :param str host_key: The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        :param str host_key_algorithm: The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        :param bool strict_host_key_checking_enabled: Indicates whether the Config Server instance will fail to start if the host_key does not match.
        """
        pulumi.set(__self__, "private_key", private_key)
        if host_key is not None:
            pulumi.set(__self__, "host_key", host_key)
        if host_key_algorithm is not None:
            pulumi.set(__self__, "host_key_algorithm", host_key_algorithm)
        if strict_host_key_checking_enabled is not None:
            pulumi.set(__self__, "strict_host_key_checking_enabled", strict_host_key_checking_enabled)

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> str:
        """
        The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        """
        return pulumi.get(self, "private_key")

    @property
    @pulumi.getter(name="hostKey")
    def host_key(self) -> Optional[str]:
        """
        The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        """
        return pulumi.get(self, "host_key")

    @property
    @pulumi.getter(name="hostKeyAlgorithm")
    def host_key_algorithm(self) -> Optional[str]:
        """
        The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        """
        return pulumi.get(self, "host_key_algorithm")

    @property
    @pulumi.getter(name="strictHostKeyCheckingEnabled")
    def strict_host_key_checking_enabled(self) -> Optional[bool]:
        """
        Indicates whether the Config Server instance will fail to start if the host_key does not match.
        """
        return pulumi.get(self, "strict_host_key_checking_enabled")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SpringCloudServiceConfigServerGitSettingSshAuth(dict):
    def __init__(__self__, *,
                 private_key: str,
                 host_key: Optional[str] = None,
                 host_key_algorithm: Optional[str] = None,
                 strict_host_key_checking_enabled: Optional[bool] = None):
        """
        :param str private_key: The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        :param str host_key: The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        :param str host_key_algorithm: The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        :param bool strict_host_key_checking_enabled: Indicates whether the Config Server instance will fail to start if the host_key does not match.
        """
        pulumi.set(__self__, "private_key", private_key)
        if host_key is not None:
            pulumi.set(__self__, "host_key", host_key)
        if host_key_algorithm is not None:
            pulumi.set(__self__, "host_key_algorithm", host_key_algorithm)
        if strict_host_key_checking_enabled is not None:
            pulumi.set(__self__, "strict_host_key_checking_enabled", strict_host_key_checking_enabled)

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> str:
        """
        The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        """
        return pulumi.get(self, "private_key")

    @property
    @pulumi.getter(name="hostKey")
    def host_key(self) -> Optional[str]:
        """
        The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        """
        return pulumi.get(self, "host_key")

    @property
    @pulumi.getter(name="hostKeyAlgorithm")
    def host_key_algorithm(self) -> Optional[str]:
        """
        The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        """
        return pulumi.get(self, "host_key_algorithm")

    @property
    @pulumi.getter(name="strictHostKeyCheckingEnabled")
    def strict_host_key_checking_enabled(self) -> Optional[bool]:
        """
        Indicates whether the Config Server instance will fail to start if the host_key does not match.
        """
        return pulumi.get(self, "strict_host_key_checking_enabled")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SpringCloudServiceTrace(dict):
    def __init__(__self__, *,
                 instrumentation_key: str):
        """
        :param str instrumentation_key: The Instrumentation Key used for Application Insights.
        """
        pulumi.set(__self__, "instrumentation_key", instrumentation_key)

    @property
    @pulumi.getter(name="instrumentationKey")
    def instrumentation_key(self) -> str:
        """
        The Instrumentation Key used for Application Insights.
        """
        return pulumi.get(self, "instrumentation_key")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class GetSpringCloudServiceConfigServerGitSettingResult(dict):
    def __init__(__self__, *,
                 http_basic_auths: List['outputs.GetSpringCloudServiceConfigServerGitSettingHttpBasicAuthResult'],
                 label: str,
                 repositories: List['outputs.GetSpringCloudServiceConfigServerGitSettingRepositoryResult'],
                 search_paths: List[str],
                 ssh_auths: List['outputs.GetSpringCloudServiceConfigServerGitSettingSshAuthResult'],
                 uri: str):
        """
        :param List['GetSpringCloudServiceConfigServerGitSettingHttpBasicAuthArgs'] http_basic_auths: A `http_basic_auth` block as defined below.
        :param str label: The default label of the Git repository, which is a branch name, tag name, or commit-id of the repository
        :param List['GetSpringCloudServiceConfigServerGitSettingRepositoryArgs'] repositories: One or more `repository` blocks as defined below.
        :param List[str] search_paths: An array of strings used to search subdirectories of the Git repository.
        :param List['GetSpringCloudServiceConfigServerGitSettingSshAuthArgs'] ssh_auths: A `ssh_auth` block as defined below.
        :param str uri: The URI of the Git repository
        """
        pulumi.set(__self__, "http_basic_auths", http_basic_auths)
        pulumi.set(__self__, "label", label)
        pulumi.set(__self__, "repositories", repositories)
        pulumi.set(__self__, "search_paths", search_paths)
        pulumi.set(__self__, "ssh_auths", ssh_auths)
        pulumi.set(__self__, "uri", uri)

    @property
    @pulumi.getter(name="httpBasicAuths")
    def http_basic_auths(self) -> List['outputs.GetSpringCloudServiceConfigServerGitSettingHttpBasicAuthResult']:
        """
        A `http_basic_auth` block as defined below.
        """
        return pulumi.get(self, "http_basic_auths")

    @property
    @pulumi.getter
    def label(self) -> str:
        """
        The default label of the Git repository, which is a branch name, tag name, or commit-id of the repository
        """
        return pulumi.get(self, "label")

    @property
    @pulumi.getter
    def repositories(self) -> List['outputs.GetSpringCloudServiceConfigServerGitSettingRepositoryResult']:
        """
        One or more `repository` blocks as defined below.
        """
        return pulumi.get(self, "repositories")

    @property
    @pulumi.getter(name="searchPaths")
    def search_paths(self) -> List[str]:
        """
        An array of strings used to search subdirectories of the Git repository.
        """
        return pulumi.get(self, "search_paths")

    @property
    @pulumi.getter(name="sshAuths")
    def ssh_auths(self) -> List['outputs.GetSpringCloudServiceConfigServerGitSettingSshAuthResult']:
        """
        A `ssh_auth` block as defined below.
        """
        return pulumi.get(self, "ssh_auths")

    @property
    @pulumi.getter
    def uri(self) -> str:
        """
        The URI of the Git repository
        """
        return pulumi.get(self, "uri")


@pulumi.output_type
class GetSpringCloudServiceConfigServerGitSettingHttpBasicAuthResult(dict):
    def __init__(__self__, *,
                 password: str,
                 username: str):
        """
        :param str password: The password used to access the Http Basic Authentication Git repository server.
        :param str username: The username used to access the Http Basic Authentication Git repository server.
        """
        pulumi.set(__self__, "password", password)
        pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> str:
        """
        The password used to access the Http Basic Authentication Git repository server.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def username(self) -> str:
        """
        The username used to access the Http Basic Authentication Git repository server.
        """
        return pulumi.get(self, "username")


@pulumi.output_type
class GetSpringCloudServiceConfigServerGitSettingRepositoryResult(dict):
    def __init__(__self__, *,
                 http_basic_auths: List['outputs.GetSpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthResult'],
                 label: str,
                 name: str,
                 patterns: List[str],
                 search_paths: List[str],
                 ssh_auths: List['outputs.GetSpringCloudServiceConfigServerGitSettingRepositorySshAuthResult'],
                 uri: str):
        """
        :param List['GetSpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthArgs'] http_basic_auths: A `http_basic_auth` block as defined below.
        :param str label: The default label of the Git repository, which is a branch name, tag name, or commit-id of the repository
        :param str name: Specifies The name of the Spring Cloud Service resource.
        :param List[str] patterns: An array of strings used to match an application name. For each pattern, use the `{application}/{profile}` format with wildcards.
        :param List[str] search_paths: An array of strings used to search subdirectories of the Git repository.
        :param List['GetSpringCloudServiceConfigServerGitSettingRepositorySshAuthArgs'] ssh_auths: A `ssh_auth` block as defined below.
        :param str uri: The URI of the Git repository
        """
        pulumi.set(__self__, "http_basic_auths", http_basic_auths)
        pulumi.set(__self__, "label", label)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "patterns", patterns)
        pulumi.set(__self__, "search_paths", search_paths)
        pulumi.set(__self__, "ssh_auths", ssh_auths)
        pulumi.set(__self__, "uri", uri)

    @property
    @pulumi.getter(name="httpBasicAuths")
    def http_basic_auths(self) -> List['outputs.GetSpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthResult']:
        """
        A `http_basic_auth` block as defined below.
        """
        return pulumi.get(self, "http_basic_auths")

    @property
    @pulumi.getter
    def label(self) -> str:
        """
        The default label of the Git repository, which is a branch name, tag name, or commit-id of the repository
        """
        return pulumi.get(self, "label")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Specifies The name of the Spring Cloud Service resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def patterns(self) -> List[str]:
        """
        An array of strings used to match an application name. For each pattern, use the `{application}/{profile}` format with wildcards.
        """
        return pulumi.get(self, "patterns")

    @property
    @pulumi.getter(name="searchPaths")
    def search_paths(self) -> List[str]:
        """
        An array of strings used to search subdirectories of the Git repository.
        """
        return pulumi.get(self, "search_paths")

    @property
    @pulumi.getter(name="sshAuths")
    def ssh_auths(self) -> List['outputs.GetSpringCloudServiceConfigServerGitSettingRepositorySshAuthResult']:
        """
        A `ssh_auth` block as defined below.
        """
        return pulumi.get(self, "ssh_auths")

    @property
    @pulumi.getter
    def uri(self) -> str:
        """
        The URI of the Git repository
        """
        return pulumi.get(self, "uri")


@pulumi.output_type
class GetSpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthResult(dict):
    def __init__(__self__, *,
                 password: str,
                 username: str):
        """
        :param str password: The password used to access the Http Basic Authentication Git repository server.
        :param str username: The username used to access the Http Basic Authentication Git repository server.
        """
        pulumi.set(__self__, "password", password)
        pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> str:
        """
        The password used to access the Http Basic Authentication Git repository server.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def username(self) -> str:
        """
        The username used to access the Http Basic Authentication Git repository server.
        """
        return pulumi.get(self, "username")


@pulumi.output_type
class GetSpringCloudServiceConfigServerGitSettingRepositorySshAuthResult(dict):
    def __init__(__self__, *,
                 host_key: str,
                 host_key_algorithm: str,
                 private_key: str,
                 strict_host_key_checking_enabled: bool):
        """
        :param str host_key: The host key of the Git repository server.
        :param str host_key_algorithm: The host key algorithm.
        :param str private_key: The SSH private key to access the Git repository, needed when the URI starts with `git@` or `ssh://`.
        :param bool strict_host_key_checking_enabled: Indicates whether the Config Server instance will fail to start if the host_key does not match.
        """
        pulumi.set(__self__, "host_key", host_key)
        pulumi.set(__self__, "host_key_algorithm", host_key_algorithm)
        pulumi.set(__self__, "private_key", private_key)
        pulumi.set(__self__, "strict_host_key_checking_enabled", strict_host_key_checking_enabled)

    @property
    @pulumi.getter(name="hostKey")
    def host_key(self) -> str:
        """
        The host key of the Git repository server.
        """
        return pulumi.get(self, "host_key")

    @property
    @pulumi.getter(name="hostKeyAlgorithm")
    def host_key_algorithm(self) -> str:
        """
        The host key algorithm.
        """
        return pulumi.get(self, "host_key_algorithm")

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> str:
        """
        The SSH private key to access the Git repository, needed when the URI starts with `git@` or `ssh://`.
        """
        return pulumi.get(self, "private_key")

    @property
    @pulumi.getter(name="strictHostKeyCheckingEnabled")
    def strict_host_key_checking_enabled(self) -> bool:
        """
        Indicates whether the Config Server instance will fail to start if the host_key does not match.
        """
        return pulumi.get(self, "strict_host_key_checking_enabled")


@pulumi.output_type
class GetSpringCloudServiceConfigServerGitSettingSshAuthResult(dict):
    def __init__(__self__, *,
                 host_key: str,
                 host_key_algorithm: str,
                 private_key: str,
                 strict_host_key_checking_enabled: bool):
        """
        :param str host_key: The host key of the Git repository server.
        :param str host_key_algorithm: The host key algorithm.
        :param str private_key: The SSH private key to access the Git repository, needed when the URI starts with `git@` or `ssh://`.
        :param bool strict_host_key_checking_enabled: Indicates whether the Config Server instance will fail to start if the host_key does not match.
        """
        pulumi.set(__self__, "host_key", host_key)
        pulumi.set(__self__, "host_key_algorithm", host_key_algorithm)
        pulumi.set(__self__, "private_key", private_key)
        pulumi.set(__self__, "strict_host_key_checking_enabled", strict_host_key_checking_enabled)

    @property
    @pulumi.getter(name="hostKey")
    def host_key(self) -> str:
        """
        The host key of the Git repository server.
        """
        return pulumi.get(self, "host_key")

    @property
    @pulumi.getter(name="hostKeyAlgorithm")
    def host_key_algorithm(self) -> str:
        """
        The host key algorithm.
        """
        return pulumi.get(self, "host_key_algorithm")

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> str:
        """
        The SSH private key to access the Git repository, needed when the URI starts with `git@` or `ssh://`.
        """
        return pulumi.get(self, "private_key")

    @property
    @pulumi.getter(name="strictHostKeyCheckingEnabled")
    def strict_host_key_checking_enabled(self) -> bool:
        """
        Indicates whether the Config Server instance will fail to start if the host_key does not match.
        """
        return pulumi.get(self, "strict_host_key_checking_enabled")

